Imports TrueMarketing

Public Class ScanTest
    Public GryMag As TrueMarketing.TrueMarketing = New TrueMarketing.TrueMarketing

      Private Sub cmdOpenPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpenPort.Click
        If cbPuerto.SelectedItem = Nothing Then
            MsgBox("Debe seleccionar un puerto")
        Else
            GryMag.puerto = cbPuerto.SelectedItem
            GryMag.tipo_lector = 1
            GryMag.OpenPuerto()
          
            txtScannerStatus.Text = "Puerto abierto..."
            Timer1.Enabled = True
        End If
    End Sub

   Private Sub cmdLeerScanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeerScanner.Click
        leerScanner()
    End Sub

    Sub leerScanner()
        If GryMag.Cedula = "" Then
            txtScannerStatus.Text = "Esperando cédula..."
            Exit Sub
        Else
            txtCedula.Text = GryMag.Cedula
            txtApellidoPaterno.Text = GryMag.Apellido_Paterno
            txtApellidoMaterno.Text = GryMag.Apellido_Materno
            txtApellidoCasada.Text = GryMag.Apellido_Casada
            corrigeFechaNacimiento(GryMag.Fecha_Nacimiento)
            CorrigePrimerNombre(GryMag.Nombres)
            corrigeFormatoCedula(GryMag.Cedula)
            txtSexo.Text = GryMag.Sexo
            Timer2.Enabled = True

        End If
    End Sub

    Sub CorrigePrimerNombre(ByVal nombre As String)
        Dim posicion As Integer
        Dim longitud As Integer
        Dim Nombre1 As String = ""
        Dim Nombre2 As String = ""

        posicion = InStr(nombre, " ")
        longitud = nombre.Length
        If posicion <> 0 Then
            Nombre1 = Strings.Left(nombre, posicion - 1)
            Nombre2 = Strings.Mid(nombre, posicion, longitud)
        Else
            Nombre1 = nombre
        End If
        txtPrimerNombre.Text = Nombre1
        txtSegundoNombre.Text = Nombre2

    End Sub

    Sub corrigeFechaNacimiento(ByVal fechaNacimiento As String)
        'Dim Fechax As Date
        Dim strFecha As String
        Dim strAño As String
        Dim strMes As String
        Dim strDia As String
        strAño = Strings.Left(fechaNacimiento, 4)
        strMes = Strings.Mid(fechaNacimiento, 5, 2)
        strDia = Strings.Right(fechaNacimiento, 2)

        strFecha = strDia & "/" & strMes & "/" & strAño
        'Fechax = strFecha 'Convert.ToDateTime(strFecha)

        TextBox1.Text = strFecha
    End Sub

    Sub corrigeFormatoCedula(ByVal Cedulax As String)
        Dim tomo As String = ""
        Dim letras As String = ""
        Dim folio As String
        Dim asiento As String
        Dim longitud As Integer = Cedulax.Length
        Dim PrimerGuion As Integer
        Dim SegundoGuion As Integer

        Dim primerTercio As String
        Dim segundoTercio As String
        Dim tercerTercio As String
        Dim LongitudSegundoTercio As Integer
        Dim LongitudPrimerTercio As Integer


        PrimerGuion = InStr(Cedulax, "-")
        If PrimerGuion <> 0 Then    ' detecta si la cédula tiene guiones
            SegundoGuion = InStr(PrimerGuion + 1, Cedulax, "-")
            primerTercio = Strings.Left(Cedulax, PrimerGuion - 1)
            tercerTercio = Strings.Right(Cedulax, longitud - SegundoGuion)

            LongitudSegundoTercio = SegundoGuion - 1 - PrimerGuion
            segundoTercio = Strings.Mid(Cedulax, PrimerGuion + 1, LongitudSegundoTercio)
            folio = segundoTercio
            asiento = tercerTercio

            If IsNumeric(primerTercio) Then
                tomo = primerTercio
            Else
                LongitudPrimerTercio = primerTercio.Length
                Dim i As Long
                Dim Valor As String

                For i = 1 To LongitudPrimerTercio
                    Valor = Mid(txtCedula.Text, i, 1)
                    If IsNumeric(Valor) Then
                        tomo = tomo + Valor
                    Else
                        letras = letras + Valor
                    End If
                Next
            End If
            txtTomo.Text = Strings.Right("00" + tomo, 2)
            txtLetras.Text = letras
            txtFolio.Text = Strings.Right("00000" + folio, 5)
            txtAsiento.Text = Strings.Right("000000" + asiento, 6)

        Else
            primerTercio = Strings.Left(Cedulax, 4)
            segundoTercio = Strings.Mid(Cedulax, 5, 4)
            tercerTercio = Strings.Right(Cedulax, 5)

            txtTomo.Text = Strings.Left(primerTercio, 2)
            txtLetras.Text = Strings.Right(primerTercio, 2)
            txtFolio.Text = "0" + segundoTercio
            txtAsiento.Text = "0" + tercerTercio
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        leerScanner()
    End Sub

    Private Sub ScanTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtScannerStatus.Text = ""

        For Each s As String In My.Computer.Ports.SerialPortNames
            'Lista.Items.Add(s)
            cbPuerto.Items.Add(s)
        Next
        cbPuerto.Select()

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick

        Timer2.Enabled = False

        GryMag.Cedula = ""
        GryMag.Apellido_Casada = ""
        GryMag.Apellido_Materno = ""
        GryMag.Apellido_Paterno = ""
        GryMag.Fecha_Nacimiento = ""
        GryMag.Fecha_Vencimiento = ""
        GryMag.Nombre_Usual = ""
        GryMag.Nombres = ""
        GryMag.Sexo = ""

        txtCedula.Text = ""
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtApellidoCasada.Text = ""

        TextBox1.Text = ""
        txtTomo.Text = ""
        txtLetras.Text = ""
        txtFolio.Text = ""
        txtAsiento.Text = ""
        txtSexo.Text = ""

    End Sub
End Class
