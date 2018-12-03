namespace RoutePlannerStageOpdracht2
{
    partial class RouteTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteTableForm));
            this.SetGreenhouse = new System.Windows.Forms.Button();
            this.P_GridGreenHouse = new System.Windows.Forms.Panel();
            this.PB_GreyBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.P_CheckLegacy = new System.Windows.Forms.Panel();
            this.BtnDrawConnections = new System.Windows.Forms.Button();
            this.btnReadCoordinaten = new System.Windows.Forms.Button();
            this.BtnCoordinaten = new System.Windows.Forms.Button();
            this.P_Explanation = new System.Windows.Forms.Panel();
            this.P_Logo = new System.Windows.Forms.Panel();
            this.P_NodeEdit = new System.Windows.Forms.Panel();
            this.P_NodeCurrentW = new System.Windows.Forms.Panel();
            this.Tb_CurrentNode = new System.Windows.Forms.TextBox();
            this.P_NodeOutConW = new System.Windows.Forms.Panel();
            this.Tb_OutCon = new System.Windows.Forms.TextBox();
            this.P_NodeInConW = new System.Windows.Forms.Panel();
            this.Tb_InCon = new System.Windows.Forms.TextBox();
            this.P_UpdateNode = new System.Windows.Forms.Panel();
            this.Btn_DeleteNode = new System.Windows.Forms.Button();
            this.Btn_UpdateNode = new System.Windows.Forms.Button();
            this.P_NodeInCon = new System.Windows.Forms.Panel();
            this.Lbl_InCon = new System.Windows.Forms.Label();
            this.P_NodeOutCon = new System.Windows.Forms.Panel();
            this.Lbl_OutCon = new System.Windows.Forms.Label();
            this.P_NodeCurrent = new System.Windows.Forms.Panel();
            this.Lbl_CurrentNode = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GetSavedGrid = new System.Windows.Forms.FolderBrowserDialog();
            this.P_GridGreenHouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_GreyBox1)).BeginInit();
            this.P_CheckLegacy.SuspendLayout();
            this.P_NodeEdit.SuspendLayout();
            this.P_NodeCurrentW.SuspendLayout();
            this.P_NodeOutConW.SuspendLayout();
            this.P_NodeInConW.SuspendLayout();
            this.P_UpdateNode.SuspendLayout();
            this.P_NodeInCon.SuspendLayout();
            this.P_NodeOutCon.SuspendLayout();
            this.P_NodeCurrent.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetGreenhouse
            // 
            this.SetGreenhouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(150)))), ((int)(((byte)(216)))));
            this.SetGreenhouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetGreenhouse.ForeColor = System.Drawing.SystemColors.Window;
            this.SetGreenhouse.Location = new System.Drawing.Point(20, 46);
            this.SetGreenhouse.Name = "SetGreenhouse";
            this.SetGreenhouse.Size = new System.Drawing.Size(170, 23);
            this.SetGreenhouse.TabIndex = 0;
            this.SetGreenhouse.Text = "Get Connections";
            this.SetGreenhouse.UseVisualStyleBackColor = false;
            this.SetGreenhouse.Click += new System.EventHandler(this.SetGreenhouse_Click);
            // 
            // P_GridGreenHouse
            // 
            this.P_GridGreenHouse.BackColor = System.Drawing.Color.White;
            this.P_GridGreenHouse.Controls.Add(this.PB_GreyBox1);
            this.P_GridGreenHouse.Location = new System.Drawing.Point(12, 12);
            this.P_GridGreenHouse.Name = "P_GridGreenHouse";
            this.P_GridGreenHouse.Size = new System.Drawing.Size(288, 296);
            this.P_GridGreenHouse.TabIndex = 3;
            this.P_GridGreenHouse.Paint += new System.Windows.Forms.PaintEventHandler(this.P_GridGreenHouse_Paint);
            // 
            // PB_GreyBox1
            // 
            this.PB_GreyBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.PB_GreyBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_GreyBox1.Location = new System.Drawing.Point(0, 0);
            this.PB_GreyBox1.Name = "PB_GreyBox1";
            this.PB_GreyBox1.Size = new System.Drawing.Size(30, 30);
            this.PB_GreyBox1.TabIndex = 6;
            this.PB_GreyBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(20, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "C:\\Users\\Daniel\\Desktop\\IO_Lijst Appelman.csv";
            // 
            // P_CheckLegacy
            // 
            this.P_CheckLegacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.P_CheckLegacy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_CheckLegacy.Controls.Add(this.BtnDrawConnections);
            this.P_CheckLegacy.Controls.Add(this.btnReadCoordinaten);
            this.P_CheckLegacy.Controls.Add(this.BtnCoordinaten);
            this.P_CheckLegacy.Controls.Add(this.textBox2);
            this.P_CheckLegacy.Controls.Add(this.SetGreenhouse);
            this.P_CheckLegacy.Location = new System.Drawing.Point(310, 10);
            this.P_CheckLegacy.Name = "P_CheckLegacy";
            this.P_CheckLegacy.Size = new System.Drawing.Size(210, 298);
            this.P_CheckLegacy.TabIndex = 5;
            // 
            // BtnDrawConnections
            // 
            this.BtnDrawConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(150)))), ((int)(((byte)(216)))));
            this.BtnDrawConnections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDrawConnections.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnDrawConnections.Location = new System.Drawing.Point(20, 133);
            this.BtnDrawConnections.Name = "BtnDrawConnections";
            this.BtnDrawConnections.Size = new System.Drawing.Size(170, 23);
            this.BtnDrawConnections.TabIndex = 7;
            this.BtnDrawConnections.Text = "Draw connections";
            this.BtnDrawConnections.UseVisualStyleBackColor = false;
            this.BtnDrawConnections.Click += new System.EventHandler(this.BtnDrawConnections_Click);
            // 
            // btnReadCoordinaten
            // 
            this.btnReadCoordinaten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(150)))), ((int)(((byte)(216)))));
            this.btnReadCoordinaten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReadCoordinaten.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReadCoordinaten.Location = new System.Drawing.Point(20, 104);
            this.btnReadCoordinaten.Name = "btnReadCoordinaten";
            this.btnReadCoordinaten.Size = new System.Drawing.Size(170, 23);
            this.btnReadCoordinaten.TabIndex = 6;
            this.btnReadCoordinaten.Text = "Get Saved Greenhouse Grid";
            this.btnReadCoordinaten.UseVisualStyleBackColor = false;
            this.btnReadCoordinaten.Click += new System.EventHandler(this.btnReadCoordinaten_Click);
            // 
            // BtnCoordinaten
            // 
            this.BtnCoordinaten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(150)))), ((int)(((byte)(216)))));
            this.BtnCoordinaten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCoordinaten.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCoordinaten.Location = new System.Drawing.Point(20, 75);
            this.BtnCoordinaten.Name = "BtnCoordinaten";
            this.BtnCoordinaten.Size = new System.Drawing.Size(170, 23);
            this.BtnCoordinaten.TabIndex = 5;
            this.BtnCoordinaten.Text = "Save Greenhouse Grid";
            this.BtnCoordinaten.UseVisualStyleBackColor = false;
            this.BtnCoordinaten.Click += new System.EventHandler(this.BtnCoordinaten_Click);
            // 
            // P_Explanation
            // 
            this.P_Explanation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.P_Explanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_Explanation.Location = new System.Drawing.Point(10, 314);
            this.P_Explanation.Name = "P_Explanation";
            this.P_Explanation.Size = new System.Drawing.Size(100, 210);
            this.P_Explanation.TabIndex = 6;
            // 
            // P_Logo
            // 
            this.P_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.P_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_Logo.Location = new System.Drawing.Point(310, 315);
            this.P_Logo.Name = "P_Logo";
            this.P_Logo.Size = new System.Drawing.Size(210, 210);
            this.P_Logo.TabIndex = 7;
            // 
            // P_NodeEdit
            // 
            this.P_NodeEdit.BackColor = System.Drawing.Color.White;
            this.P_NodeEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_NodeEdit.Controls.Add(this.P_NodeCurrentW);
            this.P_NodeEdit.Controls.Add(this.P_NodeOutConW);
            this.P_NodeEdit.Controls.Add(this.P_NodeInConW);
            this.P_NodeEdit.Controls.Add(this.P_UpdateNode);
            this.P_NodeEdit.Controls.Add(this.P_NodeInCon);
            this.P_NodeEdit.Controls.Add(this.P_NodeOutCon);
            this.P_NodeEdit.Controls.Add(this.P_NodeCurrent);
            this.P_NodeEdit.Location = new System.Drawing.Point(120, 314);
            this.P_NodeEdit.Name = "P_NodeEdit";
            this.P_NodeEdit.Size = new System.Drawing.Size(180, 210);
            this.P_NodeEdit.TabIndex = 7;
            // 
            // P_NodeCurrentW
            // 
            this.P_NodeCurrentW.BackColor = System.Drawing.Color.White;
            this.P_NodeCurrentW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_NodeCurrentW.Controls.Add(this.Tb_CurrentNode);
            this.P_NodeCurrentW.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.P_NodeCurrentW.Location = new System.Drawing.Point(0, 36);
            this.P_NodeCurrentW.Name = "P_NodeCurrentW";
            this.P_NodeCurrentW.Size = new System.Drawing.Size(180, 30);
            this.P_NodeCurrentW.TabIndex = 8;
            // 
            // Tb_CurrentNode
            // 
            this.Tb_CurrentNode.Location = new System.Drawing.Point(5, 3);
            this.Tb_CurrentNode.Name = "Tb_CurrentNode";
            this.Tb_CurrentNode.Size = new System.Drawing.Size(160, 20);
            this.Tb_CurrentNode.TabIndex = 0;
            // 
            // P_NodeOutConW
            // 
            this.P_NodeOutConW.BackColor = System.Drawing.Color.White;
            this.P_NodeOutConW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_NodeOutConW.Controls.Add(this.Tb_OutCon);
            this.P_NodeOutConW.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.P_NodeOutConW.Location = new System.Drawing.Point(10, 92);
            this.P_NodeOutConW.Name = "P_NodeOutConW";
            this.P_NodeOutConW.Size = new System.Drawing.Size(180, 30);
            this.P_NodeOutConW.TabIndex = 9;
            // 
            // Tb_OutCon
            // 
            this.Tb_OutCon.Location = new System.Drawing.Point(9, 5);
            this.Tb_OutCon.Name = "Tb_OutCon";
            this.Tb_OutCon.Size = new System.Drawing.Size(160, 20);
            this.Tb_OutCon.TabIndex = 2;
            // 
            // P_NodeInConW
            // 
            this.P_NodeInConW.BackColor = System.Drawing.Color.White;
            this.P_NodeInConW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_NodeInConW.Controls.Add(this.Tb_InCon);
            this.P_NodeInConW.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.P_NodeInConW.Location = new System.Drawing.Point(4, 145);
            this.P_NodeInConW.Name = "P_NodeInConW";
            this.P_NodeInConW.Size = new System.Drawing.Size(180, 30);
            this.P_NodeInConW.TabIndex = 10;
            // 
            // Tb_InCon
            // 
            this.Tb_InCon.Location = new System.Drawing.Point(9, 5);
            this.Tb_InCon.Name = "Tb_InCon";
            this.Tb_InCon.Size = new System.Drawing.Size(160, 20);
            this.Tb_InCon.TabIndex = 4;
            // 
            // P_UpdateNode
            // 
            this.P_UpdateNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.P_UpdateNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_UpdateNode.Controls.Add(this.Btn_DeleteNode);
            this.P_UpdateNode.Controls.Add(this.Btn_UpdateNode);
            this.P_UpdateNode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.P_UpdateNode.Location = new System.Drawing.Point(4, 181);
            this.P_UpdateNode.Name = "P_UpdateNode";
            this.P_UpdateNode.Size = new System.Drawing.Size(180, 30);
            this.P_UpdateNode.TabIndex = 10;
            // 
            // Btn_DeleteNode
            // 
            this.Btn_DeleteNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(150)))), ((int)(((byte)(216)))));
            this.Btn_DeleteNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_DeleteNode.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_DeleteNode.Location = new System.Drawing.Point(95, 3);
            this.Btn_DeleteNode.Name = "Btn_DeleteNode";
            this.Btn_DeleteNode.Size = new System.Drawing.Size(74, 20);
            this.Btn_DeleteNode.TabIndex = 6;
            this.Btn_DeleteNode.Text = "Delete node";
            this.Btn_DeleteNode.UseVisualStyleBackColor = false;
            this.Btn_DeleteNode.Click += new System.EventHandler(this.Btn_DeleteNode_Click);
            // 
            // Btn_UpdateNode
            // 
            this.Btn_UpdateNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(150)))), ((int)(((byte)(216)))));
            this.Btn_UpdateNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_UpdateNode.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_UpdateNode.Location = new System.Drawing.Point(23, 3);
            this.Btn_UpdateNode.Name = "Btn_UpdateNode";
            this.Btn_UpdateNode.Size = new System.Drawing.Size(54, 20);
            this.Btn_UpdateNode.TabIndex = 5;
            this.Btn_UpdateNode.Text = "Update node";
            this.Btn_UpdateNode.UseVisualStyleBackColor = false;
            this.Btn_UpdateNode.Click += new System.EventHandler(this.Btn_UpdateNode_Click);
            // 
            // P_NodeInCon
            // 
            this.P_NodeInCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.P_NodeInCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_NodeInCon.Controls.Add(this.Lbl_InCon);
            this.P_NodeInCon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.P_NodeInCon.Location = new System.Drawing.Point(-1, 114);
            this.P_NodeInCon.Name = "P_NodeInCon";
            this.P_NodeInCon.Size = new System.Drawing.Size(180, 30);
            this.P_NodeInCon.TabIndex = 9;
            // 
            // Lbl_InCon
            // 
            this.Lbl_InCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.Lbl_InCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_InCon.ForeColor = System.Drawing.Color.White;
            this.Lbl_InCon.Location = new System.Drawing.Point(6, 10);
            this.Lbl_InCon.Name = "Lbl_InCon";
            this.Lbl_InCon.Size = new System.Drawing.Size(111, 13);
            this.Lbl_InCon.TabIndex = 3;
            this.Lbl_InCon.Text = "Ingoing connections";
            this.Lbl_InCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_NodeOutCon
            // 
            this.P_NodeOutCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.P_NodeOutCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_NodeOutCon.Controls.Add(this.Lbl_OutCon);
            this.P_NodeOutCon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.P_NodeOutCon.Location = new System.Drawing.Point(0, 59);
            this.P_NodeOutCon.Name = "P_NodeOutCon";
            this.P_NodeOutCon.Size = new System.Drawing.Size(180, 30);
            this.P_NodeOutCon.TabIndex = 8;
            // 
            // Lbl_OutCon
            // 
            this.Lbl_OutCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.Lbl_OutCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_OutCon.ForeColor = System.Drawing.Color.White;
            this.Lbl_OutCon.Location = new System.Drawing.Point(6, 10);
            this.Lbl_OutCon.Name = "Lbl_OutCon";
            this.Lbl_OutCon.Size = new System.Drawing.Size(111, 13);
            this.Lbl_OutCon.TabIndex = 3;
            this.Lbl_OutCon.Text = "Outgoing connections";
            this.Lbl_OutCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_NodeCurrent
            // 
            this.P_NodeCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.P_NodeCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_NodeCurrent.Controls.Add(this.Lbl_CurrentNode);
            this.P_NodeCurrent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.P_NodeCurrent.Location = new System.Drawing.Point(0, 0);
            this.P_NodeCurrent.Name = "P_NodeCurrent";
            this.P_NodeCurrent.Size = new System.Drawing.Size(180, 30);
            this.P_NodeCurrent.TabIndex = 6;
            // 
            // Lbl_CurrentNode
            // 
            this.Lbl_CurrentNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.Lbl_CurrentNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_CurrentNode.ForeColor = System.Drawing.Color.White;
            this.Lbl_CurrentNode.Location = new System.Drawing.Point(19, 7);
            this.Lbl_CurrentNode.Name = "Lbl_CurrentNode";
            this.Lbl_CurrentNode.Size = new System.Drawing.Size(82, 13);
            this.Lbl_CurrentNode.TabIndex = 7;
            this.Lbl_CurrentNode.Text = "Current node";
            this.Lbl_CurrentNode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RouteTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(150)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(717, 537);
            this.Controls.Add(this.P_NodeEdit);
            this.Controls.Add(this.P_Logo);
            this.Controls.Add(this.P_Explanation);
            this.Controls.Add(this.P_CheckLegacy);
            this.Controls.Add(this.P_GridGreenHouse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RouteTableForm";
            this.Text = "Route Table Editor";
            this.P_GridGreenHouse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_GreyBox1)).EndInit();
            this.P_CheckLegacy.ResumeLayout(false);
            this.P_CheckLegacy.PerformLayout();
            this.P_NodeEdit.ResumeLayout(false);
            this.P_NodeCurrentW.ResumeLayout(false);
            this.P_NodeCurrentW.PerformLayout();
            this.P_NodeOutConW.ResumeLayout(false);
            this.P_NodeOutConW.PerformLayout();
            this.P_NodeInConW.ResumeLayout(false);
            this.P_NodeInConW.PerformLayout();
            this.P_UpdateNode.ResumeLayout(false);
            this.P_NodeInCon.ResumeLayout(false);
            this.P_NodeOutCon.ResumeLayout(false);
            this.P_NodeCurrent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetGreenhouse;
        private System.Windows.Forms.Panel P_GridGreenHouse;
        private System.Windows.Forms.PictureBox PB_GreyBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel P_CheckLegacy;
        private System.Windows.Forms.Panel P_Explanation;
        private System.Windows.Forms.Panel P_Logo;
        private System.Windows.Forms.Panel P_NodeEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Tb_CurrentNode;
        private System.Windows.Forms.Panel P_NodeCurrent;
        private System.Windows.Forms.Button Btn_UpdateNode;
        private System.Windows.Forms.TextBox Tb_InCon;
        private System.Windows.Forms.Label Lbl_OutCon;
        private System.Windows.Forms.TextBox Tb_OutCon;
        private System.Windows.Forms.Label Lbl_CurrentNode;
        private System.Windows.Forms.Panel P_NodeOutCon;
        private System.Windows.Forms.Panel P_UpdateNode;
        private System.Windows.Forms.Panel P_NodeInCon;
        private System.Windows.Forms.Label Lbl_InCon;
        private System.Windows.Forms.Panel P_NodeOutConW;
        private System.Windows.Forms.Panel P_NodeInConW;
        private System.Windows.Forms.Panel P_NodeCurrentW;
        private System.Windows.Forms.Button Btn_DeleteNode;
        private System.Windows.Forms.Button BtnCoordinaten;
        private System.Windows.Forms.Button btnReadCoordinaten;
        private System.Windows.Forms.FolderBrowserDialog GetSavedGrid;
        private System.Windows.Forms.Button BtnDrawConnections;
    }
}

