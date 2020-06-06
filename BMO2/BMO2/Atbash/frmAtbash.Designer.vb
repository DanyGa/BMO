<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAtbash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAtbash))
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        Me.txtPalabras = New System.Windows.Forms.TextBox()
        Me.txtResultados = New System.Windows.Forms.TextBox()
        Me.txtEncriptadas = New System.Windows.Forms.ListBox()
        Me.btnCifrar = New System.Windows.Forms.Button()
        Me.lblAtbash = New System.Windows.Forms.Label()
        Me.mnsAtbash = New System.Windows.Forms.MenuStrip()
        Me.criptogramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.salirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBMO = New System.Windows.Forms.Label()
        Me.mnsAtbash.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.Font = New System.Drawing.Font("Britannic Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrucciones.Location = New System.Drawing.Point(282, 84)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(221, 18)
        Me.lblInstrucciones.TabIndex = 30
        Me.lblInstrucciones.Text = "USAR LETRAS EN MAYUSCULA"
        '
        'txtPalabras
        '
        Me.txtPalabras.Location = New System.Drawing.Point(266, 117)
        Me.txtPalabras.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPalabras.Multiline = True
        Me.txtPalabras.Name = "txtPalabras"
        Me.txtPalabras.Size = New System.Drawing.Size(256, 47)
        Me.txtPalabras.TabIndex = 35
        '
        'txtResultados
        '
        Me.txtResultados.Location = New System.Drawing.Point(296, 239)
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.Size = New System.Drawing.Size(197, 22)
        Me.txtResultados.TabIndex = 36
        '
        'txtEncriptadas
        '
        Me.txtEncriptadas.FormattingEnabled = True
        Me.txtEncriptadas.ItemHeight = 16
        Me.txtEncriptadas.Location = New System.Drawing.Point(296, 268)
        Me.txtEncriptadas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEncriptadas.Name = "txtEncriptadas"
        Me.txtEncriptadas.Size = New System.Drawing.Size(197, 148)
        Me.txtEncriptadas.TabIndex = 33
        '
        'btnCifrar
        '
        Me.btnCifrar.Location = New System.Drawing.Point(347, 190)
        Me.btnCifrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCifrar.Name = "btnCifrar"
        Me.btnCifrar.Size = New System.Drawing.Size(100, 28)
        Me.btnCifrar.TabIndex = 32
        Me.btnCifrar.Text = "Cifrar"
        Me.btnCifrar.UseVisualStyleBackColor = True
        '
        'lblAtbash
        '
        Me.lblAtbash.AutoSize = True
        Me.lblAtbash.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtbash.Location = New System.Drawing.Point(351, 40)
        Me.lblAtbash.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAtbash.Name = "lblAtbash"
        Me.lblAtbash.Size = New System.Drawing.Size(96, 29)
        Me.lblAtbash.TabIndex = 31
        Me.lblAtbash.Text = "Atbash"
        '
        'mnsAtbash
        '
        Me.mnsAtbash.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnsAtbash.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.criptogramasToolStripMenuItem, Me.salirToolStripMenuItem})
        Me.mnsAtbash.Location = New System.Drawing.Point(0, 0)
        Me.mnsAtbash.Name = "mnsAtbash"
        Me.mnsAtbash.Size = New System.Drawing.Size(800, 28)
        Me.mnsAtbash.TabIndex = 37
        Me.mnsAtbash.Text = "menuStrip1"
        '
        'criptogramasToolStripMenuItem
        '
        Me.criptogramasToolStripMenuItem.Name = "criptogramasToolStripMenuItem"
        Me.criptogramasToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.criptogramasToolStripMenuItem.Text = "Cesar"
        '
        'salirToolStripMenuItem
        '
        Me.salirToolStripMenuItem.Name = "salirToolStripMenuItem"
        Me.salirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.salirToolStripMenuItem.Text = "Salir"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(-2, -3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(805, 457)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 34
        Me.pictureBox1.TabStop = False
        '
        'lblBMO
        '
        Me.lblBMO.AutoSize = True
        Me.lblBMO.BackColor = System.Drawing.Color.White
        Me.lblBMO.Font = New System.Drawing.Font("Britannic Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMO.Location = New System.Drawing.Point(693, 399)
        Me.lblBMO.Name = "lblBMO"
        Me.lblBMO.Size = New System.Drawing.Size(95, 42)
        Me.lblBMO.TabIndex = 38
        Me.lblBMO.Text = "BMO"
        '
        'frmAtbash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBMO)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Controls.Add(Me.txtPalabras)
        Me.Controls.Add(Me.txtResultados)
        Me.Controls.Add(Me.txtEncriptadas)
        Me.Controls.Add(Me.btnCifrar)
        Me.Controls.Add(Me.lblAtbash)
        Me.Controls.Add(Me.mnsAtbash)
        Me.Controls.Add(Me.pictureBox1)
        Me.MaximizeBox = False
        Me.Name = "frmAtbash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAtbash"
        Me.mnsAtbash.ResumeLayout(False)
        Me.mnsAtbash.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblInstrucciones As Label
    Private WithEvents txtPalabras As TextBox
    Private WithEvents txtResultados As TextBox
    Private WithEvents txtEncriptadas As ListBox
    Private WithEvents btnCifrar As Button
    Private WithEvents lblAtbash As Label
    Private WithEvents mnsAtbash As MenuStrip
    Private WithEvents criptogramasToolStripMenuItem As ToolStripMenuItem
    Private WithEvents salirToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lblBMO As Label
End Class
