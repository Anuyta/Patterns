namespace Task4
{
    partial class MainForm
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnTurnLeft = new System.Windows.Forms.Button();
            this.btnTurnRight = new System.Windows.Forms.Button();
            this.btnGetNegative = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnShowOriginal = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.ErrorImage = null;
            this.pbImage.Location = new System.Drawing.Point(74, 105);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(414, 395);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnTurnLeft
            // 
            this.btnTurnLeft.Enabled = false;
            this.btnTurnLeft.Location = new System.Drawing.Point(74, 531);
            this.btnTurnLeft.Name = "btnTurnLeft";
            this.btnTurnLeft.Size = new System.Drawing.Size(126, 77);
            this.btnTurnLeft.TabIndex = 1;
            this.btnTurnLeft.Text = "Изображение, повернутое на 90 градусов влево";
            this.btnTurnLeft.UseVisualStyleBackColor = true;
            this.btnTurnLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTurnRight
            // 
            this.btnTurnRight.Enabled = false;
            this.btnTurnRight.Location = new System.Drawing.Point(362, 531);
            this.btnTurnRight.Name = "btnTurnRight";
            this.btnTurnRight.Size = new System.Drawing.Size(126, 77);
            this.btnTurnRight.TabIndex = 2;
            this.btnTurnRight.Text = "Изображение, повернутое на 90 градусов вправо";
            this.btnTurnRight.UseVisualStyleBackColor = true;
            this.btnTurnRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGetNegative
            // 
            this.btnGetNegative.Enabled = false;
            this.btnGetNegative.Location = new System.Drawing.Point(215, 519);
            this.btnGetNegative.Name = "btnGetNegative";
            this.btnGetNegative.Size = new System.Drawing.Size(135, 42);
            this.btnGetNegative.TabIndex = 3;
            this.btnGetNegative.Text = "Негатив изображения";
            this.btnGetNegative.UseVisualStyleBackColor = true;
            this.btnGetNegative.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(121, 38);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(143, 45);
            this.btnOpenImage.TabIndex = 4;
            this.btnOpenImage.Text = "Открыть изображение";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnShowOriginal
            // 
            this.btnShowOriginal.Enabled = false;
            this.btnShowOriginal.Location = new System.Drawing.Point(215, 583);
            this.btnShowOriginal.Name = "btnShowOriginal";
            this.btnShowOriginal.Size = new System.Drawing.Size(135, 45);
            this.btnShowOriginal.TabIndex = 5;
            this.btnShowOriginal.Text = "Оригинальное изображение";
            this.btnShowOriginal.UseVisualStyleBackColor = true;
            this.btnShowOriginal.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Enabled = false;
            this.btnSaveImage.Location = new System.Drawing.Point(303, 38);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(137, 45);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "Сохранить изображение";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 678);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnShowOriginal);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.btnGetNegative);
            this.Controls.Add(this.btnTurnRight);
            this.Controls.Add(this.btnTurnLeft);
            this.Controls.Add(this.pbImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnTurnLeft;
        private System.Windows.Forms.Button btnTurnRight;
        private System.Windows.Forms.Button btnGetNegative;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnShowOriginal;
        private System.Windows.Forms.Button btnSaveImage;
    }
}

