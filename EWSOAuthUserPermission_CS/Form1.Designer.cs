namespace EWSOAuthUserPermission_CS
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
            this.btn_Auth = new System.Windows.Forms.Button();
            this.btn_GetCalendarEvents = new System.Windows.Forms.Button();
            this.btn_RefreshToken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Auth
            // 
            this.btn_Auth.Location = new System.Drawing.Point(26, 10);
            this.btn_Auth.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Auth.Name = "btn_Auth";
            this.btn_Auth.Size = new System.Drawing.Size(56, 19);
            this.btn_Auth.TabIndex = 0;
            this.btn_Auth.Text = "Auth";
            this.btn_Auth.UseVisualStyleBackColor = true;
            this.btn_Auth.Click += new System.EventHandler(this.btn_Auth_Click);
            // 
            // btn_GetCalendarEvents
            // 
            this.btn_GetCalendarEvents.Location = new System.Drawing.Point(107, 10);
            this.btn_GetCalendarEvents.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GetCalendarEvents.Name = "btn_GetCalendarEvents";
            this.btn_GetCalendarEvents.Size = new System.Drawing.Size(146, 19);
            this.btn_GetCalendarEvents.TabIndex = 1;
            this.btn_GetCalendarEvents.Text = "GetCalendarEvents";
            this.btn_GetCalendarEvents.UseVisualStyleBackColor = true;
            this.btn_GetCalendarEvents.Click += new System.EventHandler(this.btn_GetCalendarEvents_Click);
            // 
            // btn_RefreshToken
            // 
            this.btn_RefreshToken.Location = new System.Drawing.Point(26, 67);
            this.btn_RefreshToken.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RefreshToken.Name = "btn_RefreshToken";
            this.btn_RefreshToken.Size = new System.Drawing.Size(103, 19);
            this.btn_RefreshToken.TabIndex = 0;
            this.btn_RefreshToken.Text = "RefreshToken";
            this.btn_RefreshToken.UseVisualStyleBackColor = true;
            this.btn_RefreshToken.Click += new System.EventHandler(this.btn_RefreshToken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 199);
            this.Controls.Add(this.btn_GetCalendarEvents);
            this.Controls.Add(this.btn_RefreshToken);
            this.Controls.Add(this.btn_Auth);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Auth;
        private System.Windows.Forms.Button btn_GetCalendarEvents;
        private System.Windows.Forms.Button btn_RefreshToken;
    }
}

