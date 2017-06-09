Imports PackageIO
Public Class Form1
    Dim filepath As String
    Dim fdialog As New Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Title = "Open sysdata.dat"
        fdialog.Label1.Text = "Open sysdata.dat" & vbNewLine & "Backup your save before use" & vbNewLine & "Nintendogs + cats Save Editor"
        fdialog.ShowDialog()
        open.ShowDialog()
        filepath = open.FileName
        Readfile()
    End Sub
    Private Sub Readfile()
        Try
            Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
            Reader.Position = &HA0
            NumericUpDown1.Value = Reader.ReadUInt32
            Reader.Position = &H207
            NumericUpDown3.Value = Reader.ReadInt8
            Reader.Position = &H2AC
            TextBox1.Text = Reader.ReadUnicodeString(10)
            Reader.Position = &H1EAC
            TextBox2.Text = Reader.ReadUnicodeString(10)
            Reader.Position = &H3AAC
            TextBox3.Text = Reader.ReadUnicodeString(10)
        Catch ex As Exception
            fdialog.Label1.Text = "sysdata.dat not load" & vbNewLine & "Save file can be corrupted or not a Nintendogs + cats save"
            fdialog.ShowDialog()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Writefile()
    End Sub
    Private Sub Writefile()
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = &HA0
            Writer.WriteUInt32(NumericUpDown1.Value)
            Writer.Position = &H207
            Writer.WriteInt8(NumericUpDown3.Value)
            For i As Integer = 0 To 19
                Writer.Position = &H2AC + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = &H2AC
            Writer.WriteUnicodeString(TextBox1.Text)
            For i As Integer = 0 To 19
                Writer.Position = &H1EAC + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = &H1EAC
            Writer.WriteUnicodeString(TextBox2.Text)
            For i As Integer = 0 To 19
                Writer.Position = &H3AAC + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = &H3AAC
            Writer.WriteUnicodeString(TextBox3.Text)
            fdialog.Label1.Text = "File save"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Label1.Text = "An error has occured"
            fdialog.ShowDialog()
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                For i As Integer = 0 To 354
                    Writer.Position = &HA4 + i
                    Writer.WriteInt8(NumericUpDown2.Value)
                Next
                fdialog.Label1.Text = "All items has been unlocked"
                fdialog.Show()
            End If
        Catch ex As Exception
            fdialog.Label1.Text = "An error has occured, load a save file first"
            fdialog.Show()
            CheckBox1.Checked = False
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        fdialog.Label1.Text = "Author : Brion" & vbNewLine & "Special thanks to :" & vbNewLine & "- HugaTheFox (gbatemp.net)"
        fdialog.Show()
    End Sub
End Class
