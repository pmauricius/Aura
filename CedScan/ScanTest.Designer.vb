<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanTest
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
        Me.components = New System.ComponentModel.Container()
        Me.txtScannerStatus = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbPuerto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAsiento = New System.Windows.Forms.TextBox()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.txtLetras = New System.Windows.Forms.TextBox()
        Me.txtTomo = New System.Windows.Forms.TextBox()
        Me.cmdLeerScanner = New System.Windows.Forms.Button()
        Me.cmdOpenPort = New System.Windows.Forms.Button()
        Me.txtApellidoCasada = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtScannerStatus
        '
        Me.txtScannerStatus.AutoSize = True
        Me.txtScannerStatus.Location = New System.Drawing.Point(369, 46)
        Me.txtScannerStatus.Name = "txtScannerStatus"
        Me.txtScannerStatus.Size = New System.Drawing.Size(88, 13)
        Me.txtScannerStatus.TabIndex = 72
        Me.txtScannerStatus.Text = "txtScannerStatus"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(369, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Puertos:"
        '
        'cbPuerto
        '
        Me.cbPuerto.FormattingEnabled = True
        Me.cbPuerto.Location = New System.Drawing.Point(418, 15)
        Me.cbPuerto.Name = "cbPuerto"
        Me.cbPuerto.Size = New System.Drawing.Size(82, 21)
        Me.cbPuerto.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Fecha de Nacimiento:"
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(99, 162)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(100, 20)
        Me.txtSexo.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Apellido Casada:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Segundo Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Primer Nombre:"
        '
        'txtAsiento
        '
        Me.txtAsiento.Location = New System.Drawing.Point(358, 84)
        Me.txtAsiento.Name = "txtAsiento"
        Me.txtAsiento.Size = New System.Drawing.Size(49, 20)
        Me.txtAsiento.TabIndex = 48
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(301, 84)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(51, 20)
        Me.txtFolio.TabIndex = 47
        '
        'txtLetras
        '
        Me.txtLetras.Location = New System.Drawing.Point(263, 84)
        Me.txtLetras.Name = "txtLetras"
        Me.txtLetras.Size = New System.Drawing.Size(32, 20)
        Me.txtLetras.TabIndex = 46
        '
        'txtTomo
        '
        Me.txtTomo.Location = New System.Drawing.Point(218, 84)
        Me.txtTomo.Name = "txtTomo"
        Me.txtTomo.Size = New System.Drawing.Size(32, 20)
        Me.txtTomo.TabIndex = 44
        '
        'cmdLeerScanner
        '
        Me.cmdLeerScanner.Location = New System.Drawing.Point(506, 41)
        Me.cmdLeerScanner.Name = "cmdLeerScanner"
        Me.cmdLeerScanner.Size = New System.Drawing.Size(96, 23)
        Me.cmdLeerScanner.TabIndex = 65
        Me.cmdLeerScanner.Text = "Activar scanner"
        Me.cmdLeerScanner.UseVisualStyleBackColor = True
        '
        'cmdOpenPort
        '
        Me.cmdOpenPort.Location = New System.Drawing.Point(506, 12)
        Me.cmdOpenPort.Name = "cmdOpenPort"
        Me.cmdOpenPort.Size = New System.Drawing.Size(96, 23)
        Me.cmdOpenPort.TabIndex = 64
        Me.cmdOpenPort.Text = "Abrir Puerto"
        Me.cmdOpenPort.UseVisualStyleBackColor = True
        '
        'txtApellidoCasada
        '
        Me.txtApellidoCasada.Location = New System.Drawing.Point(502, 136)
        Me.txtApellidoCasada.Name = "txtApellidoCasada"
        Me.txtApellidoCasada.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoCasada.TabIndex = 53
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(307, 136)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoMaterno.TabIndex = 52
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(99, 136)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoPaterno.TabIndex = 51
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(307, 110)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtSegundoNombre.TabIndex = 50
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(99, 110)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimerNombre.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Cédula No."
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(99, 84)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 43
        Me.txtCedula.TabStop = False
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(332, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 73
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'ScanTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 254)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtScannerStatus)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbPuerto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSexo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAsiento)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.txtLetras)
        Me.Controls.Add(Me.txtTomo)
        Me.Controls.Add(Me.cmdLeerScanner)
        Me.Controls.Add(Me.cmdOpenPort)
        Me.Controls.Add(Me.txtApellidoCasada)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(Me.txtPrimerNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCedula)
        Me.Name = "ScanTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtScannerStatus As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbPuerto As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAsiento As System.Windows.Forms.TextBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtLetras As System.Windows.Forms.TextBox
    Friend WithEvents txtTomo As System.Windows.Forms.TextBox
    Friend WithEvents cmdLeerScanner As System.Windows.Forms.Button
    Friend WithEvents cmdOpenPort As System.Windows.Forms.Button
    Friend WithEvents txtApellidoCasada As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
