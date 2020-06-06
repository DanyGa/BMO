<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.lblTema = New System.Windows.Forms.Label()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.prgBarra = New System.Windows.Forms.ProgressBar()
        Me.lblBMO = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bgwBarra = New System.ComponentModel.BackgroundWorker()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTema
        '
        Me.lblTema.AutoSize = True
        Me.lblTema.BackColor = System.Drawing.Color.White
        Me.lblTema.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.Location = New System.Drawing.Point(149, 110)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(352, 33)
        Me.lblTema.TabIndex = 15
        Me.lblTema.Text = "Buenos Mensajes Ocultos"
        '
        'btnComenzar
        '
        Me.btnComenzar.Font = New System.Drawing.Font("Gill Sans MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.Location = New System.Drawing.Point(265, 236)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(131, 34)
        Me.btnComenzar.TabIndex = 14
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'prgBarra
        '
        Me.prgBarra.ForeColor = System.Drawing.Color.LimeGreen
        Me.prgBarra.Location = New System.Drawing.Point(40, 170)
        Me.prgBarra.Name = "prgBarra"
        Me.prgBarra.Size = New System.Drawing.Size(565, 28)
        Me.prgBarra.TabIndex = 13
        Me.prgBarra.UseWaitCursor = True
        '
        'lblBMO
        '
        Me.lblBMO.AutoSize = True
        Me.lblBMO.BackColor = System.Drawing.Color.Transparent
        Me.lblBMO.Font = New System.Drawing.Font("Britannic Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMO.Location = New System.Drawing.Point(227, 21)
        Me.lblBMO.Name = "lblBMO"
        Me.lblBMO.Size = New System.Drawing.Size(199, 89)
        Me.lblBMO.TabIndex = 12
        Me.lblBMO.Text = "BMO"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(650, 311)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 11
        Me.pictureBox1.TabStop = False
        '
        'bgwBarra
        '
        Me.bgwBarra.WorkerReportsProgress = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.prgBarra)
        Me.Controls.Add(Me.lblBMO)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTema As Label
    Private WithEvents btnComenzar As Button
    Private WithEvents prgBarra As ProgressBar
    Private WithEvents lblBMO As Label
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents bgwBarra As System.ComponentModel.BackgroundWorker
End Class
