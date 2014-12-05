namespace ImageProcessing
{
    partial class BinaryEroderParmForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.panelStructureColor = new System.Windows.Forms.Panel();
            this.binaryEroderParmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelActiveColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBackColor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrayscaleThreshold = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.picElement = new System.Windows.Forms.PictureBox();
            this.btnElementReference = new System.Windows.Forms.Button();
            this.lblElementSize = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.binaryEroderParmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrayscaleThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElement)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Structure element active color";
            // 
            // panelStructureColor
            // 
            this.panelStructureColor.BackColor = System.Drawing.Color.White;
            this.panelStructureColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStructureColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.binaryEroderParmsBindingSource, "SEActiveColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelStructureColor.Location = new System.Drawing.Point(164, 57);
            this.panelStructureColor.Name = "panelStructureColor";
            this.panelStructureColor.Size = new System.Drawing.Size(33, 19);
            this.panelStructureColor.TabIndex = 10;
            this.panelStructureColor.Click += new System.EventHandler(this.panelStructureColor_Click);
            // 
            // binaryEroderParmsBindingSource
            // 
            this.binaryEroderParmsBindingSource.DataSource = typeof(ImageProcessing.BinaryEroderParms);
            this.binaryEroderParmsBindingSource.CurrentItemChanged += new System.EventHandler(this.binaryEroderParmsBindingSource_CurrentItemChanged);
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
            // panelActiveColor
            // 
            this.panelActiveColor.BackColor = System.Drawing.Color.White;
            this.panelActiveColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActiveColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.binaryEroderParmsBindingSource, "ActiveColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelActiveColor.Location = new System.Drawing.Point(164, 7);
            this.panelActiveColor.Name = "panelActiveColor";
            this.panelActiveColor.Size = new System.Drawing.Size(33, 19);
            this.panelActiveColor.TabIndex = 14;
            this.panelActiveColor.Click += new System.EventHandler(this.panelActiveColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Active color";
            // 
            // panelBackColor
            // 
            this.panelBackColor.BackColor = System.Drawing.Color.White;
            this.panelBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.binaryEroderParmsBindingSource, "BlankColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelBackColor.Location = new System.Drawing.Point(164, 32);
            this.panelBackColor.Name = "panelBackColor";
            this.panelBackColor.Size = new System.Drawing.Size(33, 19);
            this.panelBackColor.TabIndex = 16;
            this.panelBackColor.Click += new System.EventHandler(this.panelBackColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Background color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Grayscale threshold";
            // 
            // txtGrayscaleThreshold
            // 
            this.txtGrayscaleThreshold.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binaryEroderParmsBindingSource, "GrayscaleThreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGrayscaleThreshold.Location = new System.Drawing.Point(164, 83);
            this.txtGrayscaleThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtGrayscaleThreshold.Name = "txtGrayscaleThreshold";
            this.txtGrayscaleThreshold.Size = new System.Drawing.Size(52, 20);
            this.txtGrayscaleThreshold.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Structure element";
            // 
            // picElement
            // 
            this.picElement.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.binaryEroderParmsBindingSource, "StructureElement", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.picElement.Location = new System.Drawing.Point(238, 32);
            this.picElement.Name = "picElement";
            this.picElement.Size = new System.Drawing.Size(110, 44);
            this.picElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picElement.TabIndex = 20;
            this.picElement.TabStop = false;
            // 
            // btnElementReference
            // 
            this.btnElementReference.Location = new System.Drawing.Point(321, 8);
            this.btnElementReference.Name = "btnElementReference";
            this.btnElementReference.Size = new System.Drawing.Size(27, 23);
            this.btnElementReference.TabIndex = 21;
            this.btnElementReference.Text = "...";
            this.btnElementReference.UseVisualStyleBackColor = true;
            this.btnElementReference.Click += new System.EventHandler(this.btnElementReference_Click);
            // 
            // lblElementSize
            // 
            this.lblElementSize.AutoSize = true;
            this.lblElementSize.Location = new System.Drawing.Point(235, 83);
            this.lblElementSize.Name = "lblElementSize";
            this.lblElementSize.Size = new System.Drawing.Size(85, 13);
            this.lblElementSize.TabIndex = 22;
            this.lblElementSize.Text = "Size: (Unknown)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BinaryEroderParmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblElementSize);
            this.Controls.Add(this.btnElementReference);
            this.Controls.Add(this.picElement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrayscaleThreshold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelBackColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelActiveColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelStructureColor);
            this.Controls.Add(this.label3);
            this.Name = "BinaryEroderParmForm";
            this.Size = new System.Drawing.Size(362, 138);
            this.Load += new System.EventHandler(this.BinaryEroderParmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.binaryEroderParmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrayscaleThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelStructureColor;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelActiveColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBackColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource binaryEroderParmsBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtGrayscaleThreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picElement;
        private System.Windows.Forms.Button btnElementReference;
        private System.Windows.Forms.Label lblElementSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
