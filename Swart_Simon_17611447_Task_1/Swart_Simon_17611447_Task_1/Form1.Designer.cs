namespace Swart_Simon_17611447_Task_1
{
    partial class Form1
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
            this.txtMap = new System.Windows.Forms.RichTextBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStartTime = new System.Windows.Forms.Button();
            this.btnStopTime = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMap
            // 
            this.txtMap.BackColor = System.Drawing.Color.White;
            this.txtMap.HideSelection = false;
            this.txtMap.Location = new System.Drawing.Point(12, 12);
            this.txtMap.Name = "txtMap";
            this.txtMap.ReadOnly = true;
            this.txtMap.Size = new System.Drawing.Size(332, 388);
            this.txtMap.TabIndex = 2;
            this.txtMap.Text = "";
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 1000;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(386, 24);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(48, 17);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Timer:";
            // 
            // btnStartTime
            // 
            this.btnStartTime.Location = new System.Drawing.Point(28, 420);
            this.btnStartTime.Name = "btnStartTime";
            this.btnStartTime.Size = new System.Drawing.Size(123, 47);
            this.btnStartTime.TabIndex = 4;
            this.btnStartTime.Text = "Start Timer";
            this.btnStartTime.UseVisualStyleBackColor = true;
            this.btnStartTime.Click += new System.EventHandler(this.btnStartTime_Click);
            // 
            // btnStopTime
            // 
            this.btnStopTime.Location = new System.Drawing.Point(209, 420);
            this.btnStopTime.Name = "btnStopTime";
            this.btnStopTime.Size = new System.Drawing.Size(123, 47);
            this.btnStopTime.TabIndex = 5;
            this.btnStopTime.Text = "Pause Timer";
            this.btnStopTime.UseVisualStyleBackColor = true;
            this.btnStopTime.Click += new System.EventHandler(this.btnStopTime_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(209, 486);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(123, 47);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 47);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Game";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 571);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStopTime);
            this.Controls.Add(this.btnStartTime);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtMap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtMap;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStartTime;
        private System.Windows.Forms.Button btnStopTime;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
    }
}

