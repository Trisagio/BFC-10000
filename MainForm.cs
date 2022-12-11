using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using BFC_10000.Properties;

using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Statistics.Analysis;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Kernels;
using Accord.DataSets.Base;
using Accord.DataSets;
using ZedGraph;

namespace BFC_10000
{
    public partial class MainForm : Form
    {
        /*#######################################################*/
        //                      Initialization
        /*#######################################################*/

        #region Initialization

        int hits;
        MulticlassSupportVectorMachine<IKernel> ksvm;

        public MainForm()
        {
            InitializeComponent();
            Application.DoEvents();

            cbStrategy.DataSource = Enum.GetValues(typeof(SelectionStrategy));
        }

        #endregion

        /*#######################################################*/
        //                 Recognition and Training
        /*#######################################################*/

        #region Recognition&Training

        private void btnClassify_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "Классификатор запущен. Это может занять некоторое время...";
            Application.DoEvents();

            hits = 0;
            progressBar.Value = 0;
            progressBar.Step = 1;
            progressBar.Maximum = dgvTesting.Rows.Count;
            progressBar.Visible = true;

            int i = 0;
            int[] expected = new int[dgvTesting.Rows.Count], predicted = new int[dgvTesting.Rows.Count];

            foreach (DataGridViewRow row in dgvTesting.Rows)
            {
                double[] input_value = (double[])row.Cells["colTestingFeatures"].Value;
                int expected_value = (int)row.Cells["colTestingExpected"].Value;

                ksvm.Method = MulticlassComputeMethod.Elimination; //MulticlassComputeMethod.Voting;
                int output_value = ksvm.Decide(input_value);

                row.Cells["colTestingOutput"].Value = output_value;

                if (expected_value == output_value)
                {
                    row.Cells[0].Style.BackColor = Color.LightGreen;
                    row.Cells[1].Style.BackColor = Color.LightGreen;
                    row.Cells[2].Style.BackColor = Color.LightGreen;
                    hits++;
                }
                else
                {
                    row.Cells[0].Style.BackColor = Color.Lavender;
                    row.Cells[1].Style.BackColor = Color.Lavender;
                    row.Cells[2].Style.BackColor = Color.Lavender;
                }

                expected[i] = expected_value;
                predicted[i] = output_value;
                i++;

                progressBar.PerformStep();
            }

            progressBar.Visible = false;
            lbStatus.Text = String.Format("Классификация завершена. Верных: {0}/{1} ({2:0%})",
                hits, dgvTesting.Rows.Count, (double)hits / dgvTesting.Rows.Count);

            var cm = new GeneralConfusionMatrix(classes: 10, expected: expected, predicted: predicted);

            lbPrecisionValue.Text = String.Format("{0}",cm.Precision);
            lbRecallValue.Text = String.Format("{0}",cm.Recall);
            lbF1Value.Text = String.Format("{0}",cm.NumberOfClasses);
            lbErrorValue.Text = String.Format("{0}", cm.Error);
            lbStandartErrorValue.Text = String.Format("{0}", cm.StandardError);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {

            lbStatus.Text = "Загрузка данных. Это может занять некторое время...";
            Application.DoEvents();

            useMethod("svm");

            btnClassify.Enabled = true;
        }

        #endregion

        /*#######################################################*/
        //                  Parameters and Other
        /*#######################################################*/

        #region Parameters&Other

        private void rbGaussian_CheckedChanged(object sender, EventArgs e)
        {
            numSigma.Enabled = true;
            numDegree.Enabled = false;
            numConstant.Enabled = false;
        }

        private void rbPolynomial_CheckedChanged(object sender, EventArgs e)
        {
            numSigma.Enabled = false;
            numDegree.Enabled = true;
            numConstant.Enabled = true;
        }

        private void optdigitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "Загрузка данных. Это может занять некоторое время...";
            Application.DoEvents();
            loadData("optdigits");

            lblSampleSize.Text = String.Format(
                "трен-ый: {0} /\n" +
                "тест-ый:  {1}",
                dgvTraining.Rows.Count,
                dgvTesting.Rows.Count);

            btnEstimate_Sigma.Enabled = true;
            btnEstimate_c.Enabled = true;
            mNISTToolStripMenuItem.Checked = false;
            optdigitsToolStripMenuItem.Checked = true;
        }

        private void mNISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "Загрузка данных. Это может занять некоторое время...";
            Application.DoEvents();
            loadData("optdigits");

            lblSampleSize.Text = String.Format(
                "трен-ый: {0} /\n" +
                "тест-ый:  {1}",
                dgvTraining.Rows.Count,
                dgvTesting.Rows.Count);

            btnEstimate_Sigma.Enabled = true;
            btnEstimate_c.Enabled = true;
            optdigitsToolStripMenuItem.Checked = false;
            mNISTToolStripMenuItem.Checked = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var app = Application.OpenForms["FormAbout"];
                if (app == null)
                {
                    FormHelp formAbout = new FormHelp();
                    formAbout.Show();
                }
                else
                {
                    app.Show();
                    app.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка! (aboutFormCalling)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEstimate_Sigma_Click(object sender, EventArgs e)
        {
            int rows = dgvTraining.Rows.Count;
            double[][] input = new double[rows][];
            for (int i = 0; i < rows; i++)
                input[i] = (double[])dgvTraining.Rows[i].Cells["colTrainingFeatures"].Value;

            Gaussian g = Gaussian.Estimate(input, input.Length / 4);

            numSigma.Value = (decimal)g.Sigma;
        }

        private void btnEstimate_c_Click(object sender, EventArgs e)
        {
            int rows = dgvTraining.Rows.Count;
            double[][] input = new double[rows][];
            for (int i = 0; i < rows; i++)
                input[i] = (double[])dgvTraining.Rows[i].Cells["colTrainingFeatures"].Value;

            IKernel kernel;
            if (rbGaussian.Checked)
                kernel = new Gaussian((double)numSigma.Value);
            else
                kernel = new Polynomial((int)numDegree.Value, (double)numConstant.Value);

            numComplexity.Value = (decimal)Math.Round(kernel.EstimateComplexity(input), 5);
        }

        #endregion

        /*#######################################################*/
        //                      Functions
        /*#######################################################*/

        #region Functions

        private IKernel createKernel()
        {
            if (rbGaussian.Checked)
                return new Gaussian((double)numSigma.Value);

            if (numDegree.Value == 1)
                return new Linear((double)numConstant.Value);

            return new Polynomial((int)numDegree.Value, (double)numConstant.Value);
        }

        private void loadData(String dataName = null)
        {
            try
            {
                switch (dataName)
                {
                    default:
                        StringReader reader = new StringReader(Resources.optdigits_tra);

                        int trainingStart = 0;
                        int trainingCount = 1000;

                        int testingStart = 1000;
                        int testingCount = 1000;

                        dgvTraining.Rows.Clear();
                        dgvTesting.Rows.Clear();

                        int c = 0;
                        int trainingSet = 0;
                        int testingSet = 0;
                        while (true)
                        {
                            char[] buffer = new char[(32 + 1) * 32];
                            int read = reader.ReadBlock(buffer, 0, buffer.Length);
                            string label = reader.ReadLine();


                            if (read < buffer.Length || label == null) break;

                            if (c > trainingStart && c <= trainingStart + trainingCount)
                            {
                                Bitmap bitmap = ImageProcessing.Extract(new String(buffer));
                                double[] features = ImageProcessing.Extract(bitmap);
                                int clabel = Int32.Parse(label);
                                dgvTraining.Rows.Add(bitmap, clabel, features);
                                trainingSet++;
                            }
                            else if (c > testingStart && c <= testingStart + testingCount)
                            {
                                Bitmap bitmap = ImageProcessing.Extract(new String(buffer));
                                double[] features = ImageProcessing.Extract(bitmap);
                                int clabel = Int32.Parse(label);
                                dgvTesting.Rows.Add(bitmap, clabel, null, features);
                                testingSet++;
                            }

                            c++;
                        }

                        optdigitsToolStripMenuItem.Checked = true;
                        lbStatus.Text = String.Format(
                            "Набор данных загружен (трен-ый: {0} / тест-ый: {1}).",
                            trainingSet, testingSet);
                        break;
                }
                btnTrain.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка! (loadData)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void useMethod(String methodName = null)
        {
            try
            {
                // Extract inputs and outputs
                int rows = dgvTraining.Rows.Count;
                double[][] input = new double[rows][];
                int[] output = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    input[i] = (double[])dgvTraining.Rows[i].Cells["colTrainingFeatures"].Value;
                    output[i] = (int)dgvTraining.Rows[i].Cells["colTrainingValue"].Value;
                }

                switch (methodName)
                {
                    case "knn":

                        break;
                    default:
                        IKernel kernel = createKernel();

                        double complexity = (double)numComplexity.Value;
                        double tolerance = (double)numTolerance.Value;
                        int cacheSize = (int)numCache.Value;
                        SelectionStrategy strategy = (SelectionStrategy)cbStrategy.SelectedItem;

                        Stopwatch sw = Stopwatch.StartNew();

                        lbStatus.Text = "Обучение...";
                        Application.DoEvents();

                        var ml = new MulticlassSupportVectorLearning<IKernel>()
                        {
                            Learner = (param) => new SequentialMinimalOptimization<IKernel>()
                            {
                                Complexity = complexity,
                                Tolerance = tolerance,
                                CacheSize = cacheSize,
                                Strategy = strategy,
                                Kernel = kernel,
                                UseKernelEstimation = true
                            }
                        };

                        ksvm = ml.Learn(input, output);

                        lbStatus.Text = "Калибровка...";
                        Application.DoEvents();

                        var mc = new MulticlassSupportVectorLearning<IKernel>()
                        {
                            Model = ksvm,

                            Learner = (p) => new ProbabilisticOutputCalibration<IKernel>()
                            {
                                Model = p.Model
                            }
                        };

                        if (ksvm.Kernel is Linear) ksvm.Compress();

                        sw.Stop();

                        double error = new ZeroOneLoss(output)
                        {
                            Mean = true
                        }.Loss(ksvm.Decide(input));

                        lbStatus.Text = String.Format(
                            "Обучение завершено ({0}ms, {1}er).",
                            sw.ElapsedMilliseconds, error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка! (useMethod)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
