Imports System.Threading


Public Class FormPrincipal
    Dim nombre_puerto As String = 1
    Dim lcEntrada As String

    Private Sub captura_puerto2()
        Dim num_puerto As Integer
        Dim returnStr As String = ""

        On Error GoTo fallo
        num_puerto = 1

        'Variable global
        nombre_puerto = "COM" & num_puerto

        Using com1 As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(nombre_puerto)
            com1.DataBits = 8
            com1.ReadTimeout = 3600
            Dim Incoming As String = com1.ReadLine()
            returnStr = Incoming
            Thread.Sleep(100)
            Incoming = com1.ReadLine()
            com1.Close()
        End Using

        LabelInfo.Text = "Dispositivo conectado correctamente !"
        LabelPuerto.Enabled = False
        TbPuerto.Enabled = False
        BtnConectar.Enabled = False

        TbPeso.Enabled = True
        BtnCapturarPeso.Enabled = True

        Exit Sub
fallo:
        MsgBox(Err.Description, vbCritical)
        LabelInfo.Text = "No se puede conectar con el dispositivo , prueba otro puerto !"

        LabelPuerto.Enabled = True
        TbPuerto.Enabled = True
        BtnConectar.Enabled = True
        TbPuerto.Text = ""

        TbPeso.Enabled = False
        BtnCapturarPeso.Enabled = False

    End Sub

    'LOAD - COMPROBAMOS LA CONEXION AL INICIAR APP
    Private Sub FormPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        captura_puerto2()
    End Sub

    'Funcion Capturar Peso
    Private Function fp_captura_peso() As Double
        Dim lnLen As Long
        Dim lnCRpos As Object
        Dim InBuffer As Object
        Dim InMiddle, InDistinct As Object
        Dim peso_final As Object = 0
        Dim n As Long
        On Error GoTo fallo
        lcEntrada = " "
        fp_captura_peso = 0

        Using com1 As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(nombre_puerto)
            Dim Incoming As String = com1.ReadLine()
            Thread.Sleep(100)
            Incoming = com1.ReadLine()
            lcEntrada = Incoming
        End Using

        'SI EL CONTENIDO ESTA SEPARADO POR COMAS Y QUEREMOS OBTENER SOLO EL PESO TENEMOS QUE TRATAR EL CONTENIDO

        'If Len(Trim(lcEntrada)) > 10 Then
        '    Dim subStrings() As String
        '    Dim TestArray() As String = Split(lcEntrada, ",")

        '    For i As Integer = 0 To TestArray.Length - 1
        '        If TestArray(i) <> "" Then
        '            If Char.IsNumber(Trim(TestArray(i))) = True Then
        '                peso_final = TestArray(i)
        '            End If
        '        End If
        '    Next

        '    If IsNumeric(peso_final) Then
        '        If peso_final >= 0 Then
        '            fp_captura_peso = Format(CDbl(peso_final), "###,##0.0000")
        '            Exit Function
        '        End If
        '    Else
        '        fp_captura_peso = 0
        '    End If
        'Else
        '    MsgBox("No se ha detectado peso, intente nuevamente...", vbCritical)
        'End If

        Exit Function

fallo:
        MsgBox(Err.Description)
    End Function

    'Boton Capturar Peso
    Private Sub BtnCapturarPeso_Click(sender As System.Object, e As System.EventArgs) Handles BtnCapturarPeso.Click
        'Capturamos el peso y lo mostramos en el textbox
        TbPeso.Text = fp_captura_peso().ToString
    End Sub

    Private Sub BtnConectar_Click(sender As System.Object, e As System.EventArgs) Handles BtnConectar.Click
        captura_puerto2()
    End Sub

 
    Private Sub BtnSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
