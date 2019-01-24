<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccumlated
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccumlated))
        Me.LabAccumlated = New System.Windows.Forms.Label()
        Me.LabNumOfOrder = New System.Windows.Forms.Label()
        Me.LabTotalSales = New System.Windows.Forms.Label()
        Me.TxtBoxNumOfOrder = New System.Windows.Forms.TextBox()
        Me.TxtBoxTotalSales = New System.Windows.Forms.TextBox()
        Me.LabAvgOfSales = New System.Windows.Forms.Label()
        Me.LabLargestSales = New System.Windows.Forms.Label()
        Me.txtAVG = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.BtnMPI = New System.Windows.Forms.Button()
        Me.BtnCA = New System.Windows.Forms.Button()
        Me.BtnBTHP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabAccumlated
        '
        Me.LabAccumlated.AutoSize = True
        Me.LabAccumlated.Location = New System.Drawing.Point(16, 10)
        Me.LabAccumlated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabAccumlated.Name = "LabAccumlated"
        Me.LabAccumlated.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabAccumlated.Size = New System.Drawing.Size(114, 15)
        Me.LabAccumlated.TabIndex = 0
        Me.LabAccumlated.Text = "Accumulated Sales"
        '
        'LabNumOfOrder
        '
        Me.LabNumOfOrder.AutoSize = True
        Me.LabNumOfOrder.Location = New System.Drawing.Point(16, 47)
        Me.LabNumOfOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNumOfOrder.Name = "LabNumOfOrder"
        Me.LabNumOfOrder.Size = New System.Drawing.Size(106, 15)
        Me.LabNumOfOrder.TabIndex = 1
        Me.LabNumOfOrder.Text = "Number of Order"
        '
        'LabTotalSales
        '
        Me.LabTotalSales.AutoSize = True
        Me.LabTotalSales.Location = New System.Drawing.Point(16, 113)
        Me.LabTotalSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTotalSales.Name = "LabTotalSales"
        Me.LabTotalSales.Size = New System.Drawing.Size(70, 15)
        Me.LabTotalSales.TabIndex = 2
        Me.LabTotalSales.Text = "Total Sales"
        '
        'TxtBoxNumOfOrder
        '
        Me.TxtBoxNumOfOrder.Location = New System.Drawing.Point(137, 47)
        Me.TxtBoxNumOfOrder.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtBoxNumOfOrder.Name = "TxtBoxNumOfOrder"
        Me.TxtBoxNumOfOrder.ReadOnly = True
        Me.TxtBoxNumOfOrder.Size = New System.Drawing.Size(132, 25)
        Me.TxtBoxNumOfOrder.TabIndex = 3
        '
        'TxtBoxTotalSales
        '
        Me.TxtBoxTotalSales.Location = New System.Drawing.Point(137, 110)
        Me.TxtBoxTotalSales.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtBoxTotalSales.Name = "TxtBoxTotalSales"
        Me.TxtBoxTotalSales.ReadOnly = True
        Me.TxtBoxTotalSales.Size = New System.Drawing.Size(132, 25)
        Me.TxtBoxTotalSales.TabIndex = 4
        '
        'LabAvgOfSales
        '
        Me.LabAvgOfSales.AutoSize = True
        Me.LabAvgOfSales.Location = New System.Drawing.Point(304, 50)
        Me.LabAvgOfSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabAvgOfSales.Name = "LabAvgOfSales"
        Me.LabAvgOfSales.Size = New System.Drawing.Size(110, 15)
        Me.LabAvgOfSales.TabIndex = 5
        Me.LabAvgOfSales.Text = "Averange of Sales"
        '
        'LabLargestSales
        '
        Me.LabLargestSales.AutoSize = True
        Me.LabLargestSales.Location = New System.Drawing.Point(318, 116)
        Me.LabLargestSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLargestSales.Name = "LabLargestSales"
        Me.LabLargestSales.Size = New System.Drawing.Size(73, 15)
        Me.LabLargestSales.TabIndex = 6
        Me.LabLargestSales.Text = "Large Sales"
        '
        'txtAVG
        '
        Me.txtAVG.Location = New System.Drawing.Point(433, 47)
        Me.txtAVG.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAVG.Name = "txtAVG"
        Me.txtAVG.ReadOnly = True
        Me.txtAVG.Size = New System.Drawing.Size(132, 25)
        Me.txtAVG.TabIndex = 7
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(433, 113)
        Me.txtMax.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.ReadOnly = True
        Me.txtMax.Size = New System.Drawing.Size(132, 25)
        Me.txtMax.TabIndex = 8
        '
        'BtnMPI
        '
        Me.BtnMPI.Font = New System.Drawing.Font("Microsoft JhengHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMPI.Location = New System.Drawing.Point(596, 12)
        Me.BtnMPI.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnMPI.Name = "BtnMPI"
        Me.BtnMPI.Size = New System.Drawing.Size(256, 40)
        Me.BtnMPI.TabIndex = 9
        Me.BtnMPI.Text = "Most Popular Ingredient"
        Me.BtnMPI.UseVisualStyleBackColor = True
        '
        'BtnCA
        '
        Me.BtnCA.Font = New System.Drawing.Font("Microsoft JhengHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCA.Location = New System.Drawing.Point(596, 70)
        Me.BtnCA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCA.Name = "BtnCA"
        Me.BtnCA.Size = New System.Drawing.Size(256, 50)
        Me.BtnCA.TabIndex = 10
        Me.BtnCA.Text = "Clear Accumulation"
        Me.BtnCA.UseVisualStyleBackColor = True
        '
        'BtnBTHP
        '
        Me.BtnBTHP.Font = New System.Drawing.Font("Microsoft JhengHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBTHP.Location = New System.Drawing.Point(596, 139)
        Me.BtnBTHP.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBTHP.Name = "BtnBTHP"
        Me.BtnBTHP.Size = New System.Drawing.Size(256, 43)
        Me.BtnBTHP.TabIndex = 11
        Me.BtnBTHP.Text = "Back To Home Page"
        Me.BtnBTHP.UseVisualStyleBackColor = True
        '
        'FrmAccumlated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.POS.My.Resources.Resources.FFFFFFFF
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(883, 210)
        Me.Controls.Add(Me.BtnBTHP)
        Me.Controls.Add(Me.BtnCA)
        Me.Controls.Add(Me.BtnMPI)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtAVG)
        Me.Controls.Add(Me.LabLargestSales)
        Me.Controls.Add(Me.LabAvgOfSales)
        Me.Controls.Add(Me.TxtBoxTotalSales)
        Me.Controls.Add(Me.TxtBoxNumOfOrder)
        Me.Controls.Add(Me.LabTotalSales)
        Me.Controls.Add(Me.LabNumOfOrder)
        Me.Controls.Add(Me.LabAccumlated)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmAccumlated"
        Me.Text = "Accumulated Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabAccumlated As System.Windows.Forms.Label
    Friend WithEvents LabNumOfOrder As System.Windows.Forms.Label
    Friend WithEvents LabTotalSales As System.Windows.Forms.Label
    Friend WithEvents TxtBoxNumOfOrder As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxTotalSales As System.Windows.Forms.TextBox
    Friend WithEvents LabAvgOfSales As System.Windows.Forms.Label
    Friend WithEvents LabLargestSales As System.Windows.Forms.Label
    Friend WithEvents txtAVG As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents BtnMPI As System.Windows.Forms.Button
    Friend WithEvents BtnCA As System.Windows.Forms.Button
    Friend WithEvents BtnBTHP As System.Windows.Forms.Button
End Class
