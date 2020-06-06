<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCesar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCesar))
        Me.lblBMO = New System.Windows.Forms.Label()
        Me.lblAtbash = New System.Windows.Forms.Label()
        Me.txtResultados = New System.Windows.Forms.TextBox()
        Me.mnsCesar = New System.Windows.Forms.MenuStrip()
        Me.AtbashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.salirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCyD = New System.Windows.Forms.ListBox()
        Me.btnDesifrar = New System.Windows.Forms.Button()
        Me.btnCifrar = New System.Windows.Forms.Button()
        Me.txtPalabras = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnsCesar.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBMO
        '
        Me.lblBMO.AutoSize = True
        Me.lblBMO.BackColor = System.Drawing.Color.White
        Me.lblBMO.Font = New System.Drawing.Font("Britannic Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMO.Location = New System.Drawing.Point(373, 497)
        Me.lblBMO.Name = "lblBMO"
        Me.lblBMO.Size = New System.Drawing.Size(95, 42)
        Me.lblBMO.TabIndex = 42
        Me.lblBMO.Text = "BMO"
        '
        'lblAtbash
        '
        Me.lblAtbash.AutoSize = True
        Me.lblAtbash.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtbash.Location = New System.Drawing.Point(188, 43)
        Me.lblAtbash.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAtbash.Name = "lblAtbash"
        Me.lblAtbash.Size = New System.Drawing.Size(77, 29)
        Me.lblAtbash.TabIndex = 41
        Me.lblAtbash.Text = "Cesar"
        '
        'txtResultados
        '
        Me.txtResultados.Location = New System.Drawing.Point(100, 278)
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.Size = New System.Drawing.Size(256, 22)
        Me.txtResultados.TabIndex = 40
        '
        'mnsCesar
        '
        Me.mnsCesar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnsCesar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtbashToolStripMenuItem, Me.salirToolStripMenuItem})
        Me.mnsCesar.Location = New System.Drawing.Point(0, 0)
        Me.mnsCesar.Name = "mnsCesar"
        Me.mnsCesar.Size = New System.Drawing.Size(478, 30)
        Me.mnsCesar.TabIndex = 39
        Me.mnsCesar.Text = "mnsCesar"
        '
        'AtbashToolStripMenuItem
        '
        Me.AtbashToolStripMenuItem.Name = "AtbashToolStripMenuItem"
        Me.AtbashToolStripMenuItem.Size = New System.Drawing.Size(69, 26)
        Me.AtbashToolStripMenuItem.Text = "Atbash"
        '
        'salirToolStripMenuItem
        '
        Me.salirToolStripMenuItem.Name = "salirToolStripMenuItem"
        Me.salirToolStripMenuItem.Size = New System.Drawing.Size(52, 26)
        Me.salirToolStripMenuItem.Text = "Salir"
        '
        'txtCyD
        '
        Me.txtCyD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCyD.FormattingEnabled = True
        Me.txtCyD.ItemHeight = 16
        Me.txtCyD.Location = New System.Drawing.Point(100, 307)
        Me.txtCyD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCyD.Name = "txtCyD"
        Me.txtCyD.Size = New System.Drawing.Size(256, 176)
        Me.txtCyD.TabIndex = 36
        '
        'btnDesifrar
        '
        Me.btnDesifrar.Location = New System.Drawing.Point(283, 193)
        Me.btnDesifrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDesifrar.Name = "btnDesifrar"
        Me.btnDesifrar.Size = New System.Drawing.Size(100, 28)
        Me.btnDesifrar.TabIndex = 35
        Me.btnDesifrar.Text = "Desifrar"
        Me.btnDesifrar.UseVisualStyleBackColor = True
        '
        'btnCifrar
        '
        Me.btnCifrar.Location = New System.Drawing.Point(71, 193)
        Me.btnCifrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCifrar.Name = "btnCifrar"
        Me.btnCifrar.Size = New System.Drawing.Size(100, 28)
        Me.btnCifrar.TabIndex = 34
        Me.btnCifrar.Text = "Cifrar"
        Me.btnCifrar.UseVisualStyleBackColor = True
        '
        'txtPalabras
        '
        Me.txtPalabras.Location = New System.Drawing.Point(100, 106)
        Me.txtPalabras.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPalabras.Multiline = True
        Me.txtPalabras.Name = "txtPalabras"
        Me.txtPalabras.Size = New System.Drawing.Size(256, 47)
        Me.txtPalabras.TabIndex = 33
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(-3, -3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(485, 562)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 37
        Me.pictureBox1.TabStop = False
        '
        'frmCesar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 557)
        Me.Controls.Add(Me.lblBMO)
        Me.Controls.Add(Me.lblAtbash)
        Me.Controls.Add(Me.txtResultados)
        Me.Controls.Add(Me.mnsCesar)
        Me.Controls.Add(Me.txtCyD)
        Me.Controls.Add(Me.btnDesifrar)
        Me.Controls.Add(Me.btnCifrar)
        Me.Controls.Add(Me.txtPalabras)
        Me.Controls.Add(Me.pictureBox1)
        Me.MaximizeBox = False
        Me.Name = "frmCesar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCesar"
        Me.mnsCesar.ResumeLayout(False)
        Me.mnsCesar.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblBMO As Label
    Private WithEvents lblAtbash As Label
    Private WithEvents txtResultados As TextBox
    Private WithEvents mnsCesar As MenuStrip
    Private WithEvents AtbashToolStripMenuItem As ToolStripMenuItem
    Private WithEvents salirToolStripMenuItem As ToolStripMenuItem
    Public WithEvents txtCyD As ListBox
    Private WithEvents btnDesifrar As Button
    Private WithEvents btnCifrar As Button
    Public WithEvents txtPalabras As TextBox
    Private WithEvents pictureBox1 As PictureBox
End Class
