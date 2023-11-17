namespace sem2_lab2 {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.functionTextBox = new System.Windows.Forms.TextBox();
      this.menuStrip3 = new System.Windows.Forms.MenuStrip();
      this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.построитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.найтиМинимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.найтиМаксимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.методНьютонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.найтиМинимумToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.решениеFx0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьГрафикToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.методПокоординатногоСпускаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.начертитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.начертитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.labelCondition = new System.Windows.Forms.Label();
      this.textBoxA = new System.Windows.Forms.TextBox();
      this.textBoxB = new System.Windows.Forms.TextBox();
      this.textBoxE = new System.Windows.Forms.TextBox();
      this.найтиМинимумToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.найтиМаксимумToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      this.panel1.SuspendLayout();
      this.menuStrip3.SuspendLayout();
      this.SuspendLayout();
      // 
      // chart
      // 
      chartArea2.Name = "ChartArea1";
      this.chart.ChartAreas.Add(chartArea2);
      legend2.Enabled = false;
      legend2.Name = "Legend1";
      this.chart.Legends.Add(legend2);
      this.chart.Location = new System.Drawing.Point(643, 161);
      this.chart.Name = "chart";
      this.chart.RightToLeft = System.Windows.Forms.RightToLeft.No;
      series2.BorderWidth = 3;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.IsVisibleInLegend = false;
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chart.Series.Add(series2);
      this.chart.Size = new System.Drawing.Size(592, 450);
      this.chart.TabIndex = 1;
      this.chart.Text = "chart1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(3, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 39);
      this.label1.TabIndex = 4;
      this.label1.Text = "f(x) = ";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Transparent;
      this.panel1.Controls.Add(this.functionTextBox);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 55);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1265, 100);
      this.panel1.TabIndex = 6;
      // 
      // functionTextBox
      // 
      this.functionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.functionTextBox.Location = new System.Drawing.Point(112, 25);
      this.functionTextBox.Name = "functionTextBox";
      this.functionTextBox.Size = new System.Drawing.Size(1111, 45);
      this.functionTextBox.TabIndex = 5;
      this.functionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // menuStrip3
      // 
      this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.методНьютонаToolStripMenuItem,
            this.методПокоординатногоСпускаToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.начертитьГрафикToolStripMenuItem});
      this.menuStrip3.Location = new System.Drawing.Point(0, 0);
      this.menuStrip3.Name = "menuStrip3";
      this.menuStrip3.Size = new System.Drawing.Size(1289, 28);
      this.menuStrip3.TabIndex = 7;
      this.menuStrip3.Text = "menuStrip3";
      // 
      // менюToolStripMenuItem
      // 
      this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьГрафикToolStripMenuItem,
            this.найтиМинимумToolStripMenuItem,
            this.найтиМаксимумToolStripMenuItem,
            this.очиститьГрафикToolStripMenuItem});
      this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
      this.менюToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
      this.менюToolStripMenuItem.Text = "Дихотомия";
      // 
      // построитьГрафикToolStripMenuItem
      // 
      this.построитьГрафикToolStripMenuItem.Name = "построитьГрафикToolStripMenuItem";
      this.построитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
      this.построитьГрафикToolStripMenuItem.Text = "Решение f(x) = 0";
      this.построитьГрафикToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикToolStripMenuItem_Click);
      // 
      // найтиМинимумToolStripMenuItem
      // 
      this.найтиМинимумToolStripMenuItem.Name = "найтиМинимумToolStripMenuItem";
      this.найтиМинимумToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
      this.найтиМинимумToolStripMenuItem.Text = "Найти минимум";
      this.найтиМинимумToolStripMenuItem.Click += new System.EventHandler(this.найтиМинимумToolStripMenuItem_Click);
      // 
      // найтиМаксимумToolStripMenuItem
      // 
      this.найтиМаксимумToolStripMenuItem.Name = "найтиМаксимумToolStripMenuItem";
      this.найтиМаксимумToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
      this.найтиМаксимумToolStripMenuItem.Text = "Найти максимум";
      this.найтиМаксимумToolStripMenuItem.Click += new System.EventHandler(this.найтиМаксимумToolStripMenuItem_Click);
      // 
      // очиститьГрафикToolStripMenuItem
      // 
      this.очиститьГрафикToolStripMenuItem.Name = "очиститьГрафикToolStripMenuItem";
      this.очиститьГрафикToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
      this.очиститьГрафикToolStripMenuItem.Text = "Очистить график";
      this.очиститьГрафикToolStripMenuItem.Click += new System.EventHandler(this.очиститьГрафикToolStripMenuItem_Click);
      // 
      // методНьютонаToolStripMenuItem
      // 
      this.методНьютонаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиМинимумToolStripMenuItem1,
            this.решениеFx0ToolStripMenuItem,
            this.очиститьГрафикToolStripMenuItem1});
      this.методНьютонаToolStripMenuItem.Name = "методНьютонаToolStripMenuItem";
      this.методНьютонаToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
      this.методНьютонаToolStripMenuItem.Text = "Метод Ньютона";
      // 
      // найтиМинимумToolStripMenuItem1
      // 
      this.найтиМинимумToolStripMenuItem1.Name = "найтиМинимумToolStripMenuItem1";
      this.найтиМинимумToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
      this.найтиМинимумToolStripMenuItem1.Text = "Найти экстремум";
      this.найтиМинимумToolStripMenuItem1.Click += new System.EventHandler(this.найтиМинимумToolStripMenuItem1_Click);
      // 
      // решениеFx0ToolStripMenuItem
      // 
      this.решениеFx0ToolStripMenuItem.Name = "решениеFx0ToolStripMenuItem";
      this.решениеFx0ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
      this.решениеFx0ToolStripMenuItem.Text = "Решение f(x) = 0";
      this.решениеFx0ToolStripMenuItem.Click += new System.EventHandler(this.решениеFx0ToolStripMenuItem_Click);
      // 
      // очиститьГрафикToolStripMenuItem1
      // 
      this.очиститьГрафикToolStripMenuItem1.Name = "очиститьГрафикToolStripMenuItem1";
      this.очиститьГрафикToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
      this.очиститьГрафикToolStripMenuItem1.Text = "Очистить график";
      // 
      // методПокоординатногоСпускаToolStripMenuItem
      // 
      this.методПокоординатногоСпускаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиМинимумToolStripMenuItem2,
            this.найтиМаксимумToolStripMenuItem1});
      this.методПокоординатногоСпускаToolStripMenuItem.Name = "методПокоординатногоСпускаToolStripMenuItem";
      this.методПокоординатногоСпускаToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
      this.методПокоординатногоСпускаToolStripMenuItem.Text = "Метод покоординатного спуска";
      // 
      // справкаToolStripMenuItem
      // 
      this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
      this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
      this.справкаToolStripMenuItem.Text = "Справка";
      // 
      // начертитьГрафикToolStripMenuItem
      // 
      this.начертитьГрафикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начертитьToolStripMenuItem});
      this.начертитьГрафикToolStripMenuItem.Name = "начертитьГрафикToolStripMenuItem";
      this.начертитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
      this.начертитьГрафикToolStripMenuItem.Text = "Начертить график";
      // 
      // начертитьToolStripMenuItem
      // 
      this.начертитьToolStripMenuItem.Name = "начертитьToolStripMenuItem";
      this.начертитьToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
      this.начертитьToolStripMenuItem.Text = "Начертить";
      this.начертитьToolStripMenuItem.Click += new System.EventHandler(this.начертитьToolStripMenuItem_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(52, 182);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 31);
      this.label2.TabIndex = 10;
      this.label2.Text = "a  = ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(52, 243);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 31);
      this.label3.TabIndex = 11;
      this.label3.Text = "b  = ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(52, 307);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(66, 31);
      this.label4.TabIndex = 13;
      this.label4.Text = "e  = ";
      // 
      // labelCondition
      // 
      this.labelCondition.AutoSize = true;
      this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelCondition.Location = new System.Drawing.Point(17, 433);
      this.labelCondition.Name = "labelCondition";
      this.labelCondition.Size = new System.Drawing.Size(0, 29);
      this.labelCondition.TabIndex = 15;
      // 
      // textBoxA
      // 
      this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxA.Location = new System.Drawing.Point(124, 177);
      this.textBoxA.Name = "textBoxA";
      this.textBoxA.Size = new System.Drawing.Size(457, 36);
      this.textBoxA.TabIndex = 16;
      // 
      // textBoxB
      // 
      this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxB.Location = new System.Drawing.Point(124, 238);
      this.textBoxB.Name = "textBoxB";
      this.textBoxB.Size = new System.Drawing.Size(457, 36);
      this.textBoxB.TabIndex = 17;
      // 
      // textBoxE
      // 
      this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxE.Location = new System.Drawing.Point(124, 302);
      this.textBoxE.Name = "textBoxE";
      this.textBoxE.Size = new System.Drawing.Size(457, 36);
      this.textBoxE.TabIndex = 18;
      // 
      // найтиМинимумToolStripMenuItem2
      // 
      this.найтиМинимумToolStripMenuItem2.Name = "найтиМинимумToolStripMenuItem2";
      this.найтиМинимумToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
      this.найтиМинимумToolStripMenuItem2.Text = "Найти минимум";
      this.найтиМинимумToolStripMenuItem2.Click += new System.EventHandler(this.найтиМинимумToolStripMenuItem2_Click);
      // 
      // найтиМаксимумToolStripMenuItem1
      // 
      this.найтиМаксимумToolStripMenuItem1.Name = "найтиМаксимумToolStripMenuItem1";
      this.найтиМаксимумToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
      this.найтиМаксимумToolStripMenuItem1.Text = "Найти максимум";
      this.найтиМаксимумToolStripMenuItem1.Click += new System.EventHandler(this.найтиМаксимумToolStripMenuItem1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1289, 704);
      this.Controls.Add(this.textBoxE);
      this.Controls.Add(this.textBoxB);
      this.Controls.Add(this.textBoxA);
      this.Controls.Add(this.labelCondition);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.chart);
      this.Controls.Add(this.menuStrip3);
      this.Name = "Form1";
      this.Text = "Dychotomy";
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.menuStrip3.ResumeLayout(false);
      this.menuStrip3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.MenuStrip menuStrip3;
    private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem построитьГрафикToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьГрафикToolStripMenuItem;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label labelCondition;
    private System.Windows.Forms.TextBox textBoxA;
    private System.Windows.Forms.TextBox textBoxB;
    private System.Windows.Forms.TextBox textBoxE;
    private System.Windows.Forms.ToolStripMenuItem найтиМинимумToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem найтиМаксимумToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem методНьютонаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem найтиМинимумToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem очиститьГрафикToolStripMenuItem1;
    private System.Windows.Forms.TextBox functionTextBox;
    private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem начертитьГрафикToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem начертитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem решениеFx0ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem методПокоординатногоСпускаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem найтиМинимумToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem найтиМаксимумToolStripMenuItem1;
  }
}

