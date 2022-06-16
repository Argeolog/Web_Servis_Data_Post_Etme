<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anasayfa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anasayfa))
        Me.Gonder_Buton = New System.Windows.Forms.Button()
        Me.Kullanıcı_Adı_Text = New System.Windows.Forms.TextBox()
        Me.Sifre_Text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Basic_Guvenlik = New System.Windows.Forms.RadioButton()
        Me.Guvenlik_Yok_Radio = New System.Windows.Forms.RadioButton()
        Me.Kaydet_Buton = New System.Windows.Forms.Button()
        Me.Uri_Text = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Gonderilen_Text = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Context_Type = New System.Windows.Forms.ComboBox()
        Me.Sunucu_Gelen_Yanıt_Text = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gonder_Buton
        '
        Me.Gonder_Buton.Location = New System.Drawing.Point(108, 432)
        Me.Gonder_Buton.Name = "Gonder_Buton"
        Me.Gonder_Buton.Size = New System.Drawing.Size(578, 45)
        Me.Gonder_Buton.TabIndex = 0
        Me.Gonder_Buton.Text = "Gönder"
        Me.Gonder_Buton.UseVisualStyleBackColor = True
        '
        'Kullanıcı_Adı_Text
        '
        Me.Kullanıcı_Adı_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kullanıcı_Adı_Text.Location = New System.Drawing.Point(108, 89)
        Me.Kullanıcı_Adı_Text.Name = "Kullanıcı_Adı_Text"
        Me.Kullanıcı_Adı_Text.Size = New System.Drawing.Size(578, 26)
        Me.Kullanıcı_Adı_Text.TabIndex = 1
        '
        'Sifre_Text
        '
        Me.Sifre_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Sifre_Text.Location = New System.Drawing.Point(108, 121)
        Me.Sifre_Text.Name = "Sifre_Text"
        Me.Sifre_Text.Size = New System.Drawing.Size(578, 26)
        Me.Sifre_Text.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kullanıcı Adı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Şifre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Basic_Guvenlik)
        Me.GroupBox1.Controls.Add(Me.Guvenlik_Yok_Radio)
        Me.GroupBox1.Controls.Add(Me.Kaydet_Buton)
        Me.GroupBox1.Controls.Add(Me.Uri_Text)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Gonderilen_Text)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Context_Type)
        Me.GroupBox1.Controls.Add(Me.Gonder_Buton)
        Me.GroupBox1.Controls.Add(Me.Kullanıcı_Adı_Text)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Sifre_Text)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 487)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Web Api Post İşlemleri"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Headers"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(108, 187)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(578, 26)
        Me.TextBox1.TabIndex = 16
        '
        'Basic_Guvenlik
        '
        Me.Basic_Guvenlik.AutoSize = True
        Me.Basic_Guvenlik.Location = New System.Drawing.Point(238, 23)
        Me.Basic_Guvenlik.Name = "Basic_Guvenlik"
        Me.Basic_Guvenlik.Size = New System.Drawing.Size(125, 17)
        Me.Basic_Guvenlik.TabIndex = 15
        Me.Basic_Guvenlik.TabStop = True
        Me.Basic_Guvenlik.Text = "Basic Authentication "
        Me.Basic_Guvenlik.UseVisualStyleBackColor = True
        '
        'Guvenlik_Yok_Radio
        '
        Me.Guvenlik_Yok_Radio.AutoSize = True
        Me.Guvenlik_Yok_Radio.Location = New System.Drawing.Point(108, 23)
        Me.Guvenlik_Yok_Radio.Name = "Guvenlik_Yok_Radio"
        Me.Guvenlik_Yok_Radio.Size = New System.Drawing.Size(113, 17)
        Me.Guvenlik_Yok_Radio.TabIndex = 14
        Me.Guvenlik_Yok_Radio.TabStop = True
        Me.Guvenlik_Yok_Radio.Text = "No Authentication "
        Me.Guvenlik_Yok_Radio.UseVisualStyleBackColor = True
        '
        'Kaydet_Buton
        '
        Me.Kaydet_Buton.Location = New System.Drawing.Point(18, 432)
        Me.Kaydet_Buton.Name = "Kaydet_Buton"
        Me.Kaydet_Buton.Size = New System.Drawing.Size(84, 45)
        Me.Kaydet_Buton.TabIndex = 13
        Me.Kaydet_Buton.Text = "Ayarları Kaydet"
        Me.Kaydet_Buton.UseVisualStyleBackColor = True
        '
        'Uri_Text
        '
        Me.Uri_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Uri_Text.Location = New System.Drawing.Point(108, 57)
        Me.Uri_Text.Name = "Uri_Text"
        Me.Uri_Text.Size = New System.Drawing.Size(578, 26)
        Me.Uri_Text.TabIndex = 11
        Me.Uri_Text.Text = "https://localhost:44326/deneme"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "URI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gönderilen Data"
        '
        'Gonderilen_Text
        '
        Me.Gonderilen_Text.Location = New System.Drawing.Point(108, 219)
        Me.Gonderilen_Text.Name = "Gonderilen_Text"
        Me.Gonderilen_Text.Size = New System.Drawing.Size(578, 207)
        Me.Gonderilen_Text.TabIndex = 9
        Me.Gonderilen_Text.Text = resources.GetString("Gonderilen_Text.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Content Type"
        '
        'Context_Type
        '
        Me.Context_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Context_Type.FormattingEnabled = True
        Me.Context_Type.Items.AddRange(New Object() {"application/json", "application/x-www-form-urlencoded", "application/xml ", "text/xml"})
        Me.Context_Type.Location = New System.Drawing.Point(108, 153)
        Me.Context_Type.Name = "Context_Type"
        Me.Context_Type.Size = New System.Drawing.Size(578, 28)
        Me.Context_Type.TabIndex = 7
        Me.Context_Type.Text = "application/json"
        '
        'Sunucu_Gelen_Yanıt_Text
        '
        Me.Sunucu_Gelen_Yanıt_Text.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sunucu_Gelen_Yanıt_Text.Location = New System.Drawing.Point(719, 56)
        Me.Sunucu_Gelen_Yanıt_Text.Name = "Sunucu_Gelen_Yanıt_Text"
        Me.Sunucu_Gelen_Yanıt_Text.Size = New System.Drawing.Size(403, 443)
        Me.Sunucu_Gelen_Yanıt_Text.TabIndex = 16
        Me.Sunucu_Gelen_Yanıt_Text.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(856, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Sunucunun Yanıtı"
        '
        'Anasayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 511)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Sunucu_Gelen_Yanıt_Text)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Anasayfa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anasayfa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gonder_Buton As System.Windows.Forms.Button
    Friend WithEvents Kullanıcı_Adı_Text As System.Windows.Forms.TextBox
    Friend WithEvents Sifre_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Gonderilen_Text As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Context_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Kaydet_Buton As System.Windows.Forms.Button
    Friend WithEvents Uri_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Basic_Guvenlik As System.Windows.Forms.RadioButton
    Friend WithEvents Guvenlik_Yok_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents Sunucu_Gelen_Yanıt_Text As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
