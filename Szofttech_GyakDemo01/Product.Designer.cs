
namespace Szofttech_GyakDemo01
{
    partial class Product
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listBoxControl1.Appearance.Options.UseFont = true;
            this.listBoxControl1.Location = new System.Drawing.Point(29, 41);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(342, 500);
            this.listBoxControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Termékek";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(405, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(164, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Új termék hozzáadása";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit1.Location = new System.Drawing.Point(405, 60);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(258, 22);
            this.textEdit1.TabIndex = 3;
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit2.Location = new System.Drawing.Point(405, 116);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEdit2.Size = new System.Drawing.Size(242, 22);
            this.textEdit2.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Location = new System.Drawing.Point(405, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Elnevezés";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Location = new System.Drawing.Point(405, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(11, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Ár";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(405, 155);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(132, 42);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Hozzáadás";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(653, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(13, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Ft";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(552, 499);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(111, 42);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Vissza";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 580);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.listBoxControl1);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termék";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Product_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}