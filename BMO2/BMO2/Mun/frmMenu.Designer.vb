<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCesar = New System.Windows.Forms.Button()
        Me.btnAtbash = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblBMO = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(232, 271)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 34)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCesar
        '
        Me.btnCesar.BackColor = System.Drawing.Color.White
        Me.btnCesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCesar.Location = New System.Drawing.Point(367, 196)
        Me.btnCesar.Name = "btnCesar"
        Me.btnCesar.Size = New System.Drawing.Size(107, 37)
        Me.btnCesar.TabIndex = 26
        Me.btnCesar.Text = "Cesar"
        Me.btnCesar.UseVisualStyleBackColor = False
        '
        'btnAtbash
        '
        Me.btnAtbash.BackColor = System.Drawing.Color.White
        Me.btnAtbash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtbash.Location = New System.Drawing.Point(78, 196)
        Me.btnAtbash.Name = "btnAtbash"
        Me.btnAtbash.Size = New System.Drawing.Size(100, 37)
        Me.btnAtbash.TabIndex = 25
        Me.btnAtbash.Text = "Atbash"
        Me.btnAtbash.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.White
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(130, 137)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(328, 24)
        Me.label2.TabIndex = 23
        Me.label2.Text = "seleccione una opcion para empezar:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.White
        Me.label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(112, 74)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(352, 33)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Buenos Mensajes Ocultos"
        '
        'lblBMO
        '
        Me.lblBMO.AutoSize = True
        Me.lblBMO.BackColor = System.Drawing.Color.White
        Me.lblBMO.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMO.Location = New System.Drawing.Point(199, 7)
        Me.lblBMO.Name = "lblBMO"
        Me.lblBMO.Size = New System.Drawing.Size(150, 67)
        Me.lblBMO.TabIndex = 22
        Me.lblBMO.Text = "BMO"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(-4, -3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(570, 358)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 21
        Me.pictureBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 353)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCesar)
        Me.Controls.Add(Me.btnAtbash)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblBMO)
        Me.Controls.Add(Me.pictureBox1)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnSalir As Button
    Private WithEvents btnCesar As Button
    Private WithEvents btnAtbash As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents lblBMO As Label
    Private WithEvents pictureBox1 As PictureBox
End Class
