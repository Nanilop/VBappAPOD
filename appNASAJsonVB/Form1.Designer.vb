<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHD = New System.Windows.Forms.RadioButton()
        Me.btnNorm = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.listFotos = New System.Windows.Forms.ComboBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFinal)
        Me.GroupBox1.Controls.Add(Me.dtpInicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'dtpFinal
        '
        Me.dtpFinal.CustomFormat = "yyyy-MM-dd"
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFinal.Location = New System.Drawing.Point(103, 36)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(82, 20)
        Me.dtpFinal.TabIndex = 3
        '
        'dtpInicial
        '
        Me.dtpInicial.CustomFormat = "yyyy-MM-dd"
        Me.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInicial.Location = New System.Drawing.Point(11, 36)
        Me.dtpInicial.Name = "dtpInicial"
        Me.dtpInicial.Size = New System.Drawing.Size(82, 20)
        Me.dtpInicial.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Consulta a NASA: Foto del Día"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHD)
        Me.GroupBox2.Controls.Add(Me.btnNorm)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 44)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calidad"
        '
        'btnHD
        '
        Me.btnHD.AutoSize = True
        Me.btnHD.Checked = True
        Me.btnHD.Location = New System.Drawing.Point(98, 18)
        Me.btnHD.Name = "btnHD"
        Me.btnHD.Size = New System.Drawing.Size(41, 17)
        Me.btnHD.TabIndex = 1
        Me.btnHD.TabStop = True
        Me.btnHD.Text = "HD"
        Me.btnHD.UseVisualStyleBackColor = True
        '
        'btnNorm
        '
        Me.btnNorm.AutoSize = True
        Me.btnNorm.Location = New System.Drawing.Point(7, 18)
        Me.btnNorm.Name = "btnNorm"
        Me.btnNorm.Size = New System.Drawing.Size(58, 17)
        Me.btnNorm.TabIndex = 0
        Me.btnNorm.Text = "Normal"
        Me.btnNorm.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.listFotos)
        Me.GroupBox3.Location = New System.Drawing.Point(378, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 44)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fotografías:"
        '
        'listFotos
        '
        Me.listFotos.Enabled = False
        Me.listFotos.FormattingEnabled = True
        Me.listFotos.Location = New System.Drawing.Point(6, 19)
        Me.listFotos.Name = "listFotos"
        Me.listFotos.Size = New System.Drawing.Size(188, 21)
        Me.listFotos.TabIndex = 0
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(585, 59)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Enabled = False
        Me.button1.Location = New System.Drawing.Point(585, 85)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 5
        Me.button1.Text = "Consultar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(14, 121)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(647, 318)
        Me.picFoto.TabIndex = 6
        Me.picFoto.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 450)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "NASA APOD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFinal As DateTimePicker
    Friend WithEvents dtpInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnHD As RadioButton
    Friend WithEvents btnNorm As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents listFotos As ComboBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents button1 As Button
    Friend WithEvents picFoto As PictureBox
End Class
