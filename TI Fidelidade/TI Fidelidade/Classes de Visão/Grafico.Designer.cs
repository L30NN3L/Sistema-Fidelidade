namespace TI_Fidelidade
{
    partial class Grafico
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Analise = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Analise)).BeginInit();
            this.SuspendLayout();
            // 
            // Analise
            // 
            lineAnnotation1.Name = "LineAnnotation1";
            this.Analise.Annotations.Add(lineAnnotation1);
            chartArea1.Name = "ChartArea1";
            this.Analise.ChartAreas.Add(chartArea1);
            this.Analise.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.Analise.Legends.Add(legend1);
            this.Analise.Location = new System.Drawing.Point(0, 0);
            this.Analise.Name = "Analise";
            this.Analise.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Fidelidade";
            this.Analise.Series.Add(series1);
            this.Analise.Size = new System.Drawing.Size(612, 337);
            this.Analise.TabIndex = 0;
            this.Analise.Text = "Análise";
            title1.Name = "Title1";
            title1.Text = "Nível de Fidelidade";
            this.Analise.Titles.Add(title1);
     
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Analise);
            this.Name = "Grafico";
            this.Size = new System.Drawing.Size(612, 337);
            this.Load += new System.EventHandler(this.Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Analise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Analise;
    }
}
