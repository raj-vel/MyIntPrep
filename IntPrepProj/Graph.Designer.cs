namespace IntPrepProj
{
    partial class Graph
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
            this.AdjacencyListImplementation = new System.Windows.Forms.Button();
            this.DFS_CloneUndirectedGraph = new System.Windows.Forms.Button();
            this.BFS_CloneUndirectedGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdjacencyListImplementation
            // 
            this.AdjacencyListImplementation.Location = new System.Drawing.Point(49, 31);
            this.AdjacencyListImplementation.Name = "AdjacencyListImplementation";
            this.AdjacencyListImplementation.Size = new System.Drawing.Size(166, 36);
            this.AdjacencyListImplementation.TabIndex = 0;
            this.AdjacencyListImplementation.Text = "Adjacency List Implementation";
            this.AdjacencyListImplementation.UseVisualStyleBackColor = true;
            this.AdjacencyListImplementation.Click += new System.EventHandler(this.AdjacencyListImplementation_Click);
            // 
            // DFS_CloneUndirectedGraph
            // 
            this.DFS_CloneUndirectedGraph.Location = new System.Drawing.Point(254, 31);
            this.DFS_CloneUndirectedGraph.Name = "DFS_CloneUndirectedGraph";
            this.DFS_CloneUndirectedGraph.Size = new System.Drawing.Size(206, 36);
            this.DFS_CloneUndirectedGraph.TabIndex = 1;
            this.DFS_CloneUndirectedGraph.Text = "Clone Undirected Graph - DFS";
            this.DFS_CloneUndirectedGraph.UseVisualStyleBackColor = true;
            this.DFS_CloneUndirectedGraph.Click += new System.EventHandler(this.DFS_CloneUndirectedGraph_Click);
            // 
            // BFS_CloneUndirectedGraph
            // 
            this.BFS_CloneUndirectedGraph.Location = new System.Drawing.Point(510, 31);
            this.BFS_CloneUndirectedGraph.Name = "BFS_CloneUndirectedGraph";
            this.BFS_CloneUndirectedGraph.Size = new System.Drawing.Size(220, 36);
            this.BFS_CloneUndirectedGraph.TabIndex = 2;
            this.BFS_CloneUndirectedGraph.Text = "Clone Undirected Graph - BFS";
            this.BFS_CloneUndirectedGraph.UseVisualStyleBackColor = true;
            this.BFS_CloneUndirectedGraph.Click += new System.EventHandler(this.BFS_CloneUndirectedGraph_Click);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 589);
            this.Controls.Add(this.BFS_CloneUndirectedGraph);
            this.Controls.Add(this.DFS_CloneUndirectedGraph);
            this.Controls.Add(this.AdjacencyListImplementation);
            this.Name = "Graph";
            this.Text = "Graph";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdjacencyListImplementation;
        private System.Windows.Forms.Button DFS_CloneUndirectedGraph;
        private System.Windows.Forms.Button BFS_CloneUndirectedGraph;
    }
}