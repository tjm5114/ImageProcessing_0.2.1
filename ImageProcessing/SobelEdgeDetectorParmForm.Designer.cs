namespace ImageProcessing
{
    partial class SobelEdgeDetectorParmForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbThreshold = new System.Windows.Forms.TrackBar();
            this.derivateiveEdgeDetectorParmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbCopyOriginal = new System.Windows.Forms.CheckBox();
            this.cbConvertOriginalImage = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBorderColor = new System.Windows.Forms.Panel();
            this.cbChannels = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derivateiveEdgeDetectorParmsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel";
            // 
            // tbThreshold
            // 
            this.tbThreshold.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.derivateiveEdgeDetectorParmsBindingSource, "Threshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbThreshold.Location = new System.Drawing.Point(57, 27);
            this.tbThreshold.Maximum = 500;
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(233, 45);
            this.tbThreshold.TabIndex = 5;
            this.tbThreshold.Value = 50;
            // 
            // derivateiveEdgeDetectorParmsBindingSource
            // 
            this.derivateiveEdgeDetectorParmsBindingSource.DataSource = typeof(ImageProcessing.DerivateiveEdgeDetectorParms);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Threshold";
            // 
            // cbCopyOriginal
            // 
            this.cbCopyOriginal.AutoSize = true;
            this.cbCopyOriginal.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.derivateiveEdgeDetectorParmsBindingSource, "CopyOriginal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbCopyOriginal.Location = new System.Drawing.Point(66, 91);
            this.cbCopyOriginal.Name = "cbCopyOriginal";
            this.cbCopyOriginal.Size = new System.Drawing.Size(117, 17);
            this.cbCopyOriginal.TabIndex = 7;
            this.cbCopyOriginal.Text = "Copy original image";
            this.cbCopyOriginal.UseVisualStyleBackColor = true;
            // 
            // cbConvertOriginalImage
            // 
            this.cbConvertOriginalImage.AutoSize = true;
            this.cbConvertOriginalImage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.derivateiveEdgeDetectorParmsBindingSource, "ConvertToGrayscale", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbConvertOriginalImage.Location = new System.Drawing.Point(66, 114);
            this.cbConvertOriginalImage.Name = "cbConvertOriginalImage";
            this.cbConvertOriginalImage.Size = new System.Drawing.Size(190, 17);
            this.cbConvertOriginalImage.TabIndex = 8;
            this.cbConvertOriginalImage.Text = "Convert original image to grayscale";
            this.cbConvertOriginalImage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Border color";
            // 
            // panelBorderColor
            // 
            this.panelBorderColor.BackColor = System.Drawing.Color.White;
            this.panelBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorderColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.derivateiveEdgeDetectorParmsBindingSource, "EdgeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelBorderColor.Location = new System.Drawing.Point(66, 59);
            this.panelBorderColor.Name = "panelBorderColor";
            this.panelBorderColor.Size = new System.Drawing.Size(33, 19);
            this.panelBorderColor.TabIndex = 10;
            this.panelBorderColor.Click += new System.EventHandler(this.panelBorderColor_Click);
            // 
            // cbChannels
            // 
            this.cbChannels.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.derivateiveEdgeDetectorParmsBindingSource, "Channel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbChannels.FormattingEnabled = true;
            this.cbChannels.Location = new System.Drawing.Point(66, 4);
            this.cbChannels.Name = "cbChannels";
            this.cbChannels.Size = new System.Drawing.Size(82, 21);
            this.cbChannels.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(273, 108);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.derivateiveEdgeDetectorParmsBindingSource, "Threshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Location = new System.Drawing.Point(297, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "50";
            // 
            // SobelEdgeDetectorParmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbChannels);
            this.Controls.Add(this.panelBorderColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbConvertOriginalImage);
            this.Controls.Add(this.cbCopyOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbThreshold);
            this.Controls.Add(this.label1);
            this.Name = "SobelEdgeDetectorParmForm";
            this.Size = new System.Drawing.Size(362, 138);
            this.Load += new System.EventHandler(this.DerivativeEdgeDetectorParmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derivateiveEdgeDetectorParmsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox cbCopyOriginal;
        private System.Windows.Forms.CheckBox cbConvertOriginalImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBorderColor;
        private System.Windows.Forms.ComboBox cbChannels;
        private System.Windows.Forms.BindingSource derivateiveEdgeDetectorParmsBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
    }
}
