Imports System.Net
Imports System.Text
Imports System.IO

Public Class Anasayfa

    Private Sub Gonder_Buton_Click(sender As Object, e As EventArgs) Handles Gonder_Buton.Click



        Try

      

            Dim Request As WebRequest = WebRequest.Create(Uri_Text.Text)
            Request.Timeout = 5000     ' 5 Saniye Yanıt Gelmesini Bekliyoruz.
            Request.Method = "POST"
            Request.ContentType = Context_Type.Text

            If Basic_Guvenlik.Checked = True Then
                Dim Credentials As String = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(Kullanıcı_Adı_Text.Text & ":" & Sifre_Text.Text))
                Request.Headers.Add("Authorization", "Basic " & Credentials)
            End If


            Dim ByteList As Byte() = Encoding.UTF8.GetBytes(Gonderilen_Text.Text)
            Request.ContentLength = ByteList.Length
            Dim DataStream As Stream = Request.GetRequestStream()
            DataStream.Write(ByteList, 0, ByteList.Length)
            DataStream.Close()
            Dim Response As WebResponse = Request.GetResponse()
            DataStream = Response.GetResponseStream()
            Dim StreamOku As New StreamReader(DataStream)

            Sunucu_Gelen_Yanıt_Text.Text = StreamOku.ReadToEnd()
            StreamOku.Close()
            Response.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Kaydet_Buton_Click(sender As Object, e As EventArgs) Handles Kaydet_Buton.Click
        Try

      
        Dim Ayar As New StreamWriter("Ayar.txt")
            Ayar.WriteLine(Guvenlik_Yok_Radio.Checked)

            Ayar.WriteLine(Uri_Text.Text)
            Ayar.WriteLine(Kullanıcı_Adı_Text.Text)
            Ayar.WriteLine(Sifre_Text.Text)
            Ayar.WriteLine(Context_Type.Text)
            Ayar.Write(Gonderilen_Text.Text)
        Ayar.Close()
        MsgBox("Ayar Kayıt Başarılı !")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Ayar_Oku()
        Try

            Dim AyarOku As New StreamReader("Ayar.txt")
            Guvenlik_Yok_Radio.Checked = AyarOku.ReadLine
            Uri_Text.Text = AyarOku.ReadLine
            Kullanıcı_Adı_Text.Text = AyarOku.ReadLine
            Sifre_Text.Text = AyarOku.ReadLine
            Context_Type.Text = AyarOku.ReadLine
            Gonderilen_Text.Text = AyarOku.ReadToEnd
            AyarOku.Close()
            Basic_Guvenlik.Checked = Not Guvenlik_Yok_Radio.Checked
            


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Anasayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Ayar_Oku()


    End Sub

    Private Sub Guvenlik_Yok_Radio_CheckedChanged(sender As Object, e As EventArgs) Handles Guvenlik_Yok_Radio.CheckedChanged
        If Guvenlik_Yok_Radio.Checked = True Then
            Kullanıcı_Adı_Text.Enabled = False
            Sifre_Text.Enabled = False
        Else
            Kullanıcı_Adı_Text.Enabled = True
            Sifre_Text.Enabled = True
        End If
    End Sub
End Class
