Imports PackageIO
Imports System.Net

Public Class Form1
    Dim filepath As String
    Dim fdialog As New Form2
    Dim applicationpath = Application.StartupPath
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Title = "Open sysdata.dat"
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            fdialog.Label1.Text = "Open sysdata.dat" & vbNewLine & "Nintendogs + cats Save Editor will make a backup of your save file" & vbNewLine & "Check ''bak'' folder"
            fdialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            fdialog.Label1.Text = "Ouvrir sysdata.dat" & vbNewLine & "Nintendogs +cats Save Editor va faire une copie de votre sauvegarde" & vbNewLine & "Vérifiez le dossier ''bak''"
            fdialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(2) Then
            fdialog.Label1.Text = "öffnen sysdata.dat" & vbNewLine & "Nintendogs +cats Save Editor wird eine Sicherungskopie Ihrer Datei speichern" & vbNewLine & "Überprüfen ''bak'' Ordner"
            fdialog.ShowDialog()
        End If
        open.Filter = "DAT files|*sysdata.dat"
        open.Title = "Open save sysdata.dat"
        open.ShowDialog()
        filepath = open.FileName
        backupsysdata()
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
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Label1.Text = "sysdata.dat not load" & vbNewLine & "Save file can be corrupted or not a Nintendogs + cats save"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Label1.Text = "L 'ouverture de sysdata.dat a échoué" & vbNewLine & "La sauvegarde peut être corrompu ou n'est pas une sauvegarde de Nintendogs + cats"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                fdialog.Label1.Text = "sysdata.dat wurde nicht geladen" & vbNewLine & "Speicherstand könnte korrupt sein oder ist kein Nintendogs + cats Speicherstand"
                fdialog.ShowDialog()
            End If
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
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Label1.Text = "File saved"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Label1.Text = "Fichier enregistré"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                fdialog.Label1.Text = "Datei gespeichert"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Label1.Text = "An error has occured"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Label1.Text = "Une erreur est survenue"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                fdialog.Label1.Text = "Ein Fehler ist aufgetreten"
                fdialog.ShowDialog()
            End If
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
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    fdialog.Label1.Text = "All items has been unlocked"
                    fdialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    fdialog.Label1.Text = "Tout les objets ont été débloqués"
                    fdialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                    fdialog.Label1.Text = "Alle artikel wurden freigeschaltet"
                    fdialog.ShowDialog()
                End If
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Label1.Text = "An error has occured, load a save file first"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Label1.Text = "Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                fdialog.Label1.Text = "Ein Fehler ist aufgetreten, lade zuerst einen Sicherungsdatei"
                fdialog.ShowDialog()
            End If
            CheckBox1.Checked = False
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_language.SelectedIndexChanged
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Button1.Text = "Open"
            Button2.Text = "Save"
            GroupBox1.Text = "Unlock all items"
            CheckBox2.Text = "Get trainer points as maximum"
            CheckBox2.Location = New Point(121, 102)
            Label2.Text = "Interiors designs"
            Label3.Text = "1st animal"
            Label4.Text = "2nd animal"
            Label5.Text = "3rd animal"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Button1.Text = "Ouvrir"
            Button2.Text = "Enregistrer"
            GroupBox1.Text = "Débloquer tout les objets"
            CheckBox2.Text = "Mettre les points d'entraineur au max"
            CheckBox2.Location = New Point(86, 102)
            Label2.Text = "Design intérieur"
            Label3.Text = "1er animal"
            Label4.Text = "2nd animal"
            Label5.Text = "3ème animal"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Button1.Text = "öffnen"
            Button2.Text = "speichern"
            GroupBox1.Text = "schalte alle Items frei"
            CheckBox2.Text = "Trainer punkte als maximum erhalten"
            CheckBox2.Location = New Point(86, 102)
            Label2.Text = "Wohnungs Designs"
            Label3.Text = "erstes Haustier"
            Label4.Text = "zweites Haustier"
            Label5.Text = "drittes Haustier"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select_language.SelectedItem = Select_language.Items.Item(0)
        Select_language.SelectedItem = My.Settings.langue
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.langue = Select_language.SelectedItem
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Try
            If CheckBox2.Checked = True Then
                Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
                Writer.Position = &H9C
                Writer.WriteUInt32(1203982208)
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    fdialog.Label1.Text = "Trainer points are maximum, all breeds has been unlocked"
                    fdialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    fdialog.Label1.Text = "Les points d'entraineur sont au maximum, toute les races ont été débloquées"
                    fdialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                    fdialog.Label1.Text = "Trainer punkte sind maximal, Alle Rassen wurden freigeschaltet"
                    fdialog.ShowDialog()
                End If
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Label1.Text = "An error has occured, load a save file first"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Label1.Text = "Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                fdialog.Label1.Text = "Ein Fehler ist aufgetreten, lade zuerst einen Sicherungsdatei"
                fdialog.ShowDialog()
            End If
            CheckBox2.Checked = False
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Form3.ShowDialog()
    End Sub

    Public Sub backupsysdata()
        Try
            My.Computer.FileSystem.CopyFile(
                          filepath,
                        applicationpath & "\bak\sysdata.dat")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Checkupdates()
        Try
            Dim MAJ As New WebClient
            Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/3ds-Nintendogs-cats-Save-Editor/master/Version.txt")
            If Label6.Text = lastupdate Then
                NCSE_logo_update.Visible = False
            Else
                NCSE_logo_update.Visible = True
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    fdialog.Label1.Text = "An update is available" & vbNewLine & vbNewLine & "Click on 'New update avaible'" & vbNewLine & "to download new version"
                    fdialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    fdialog.Label1.Text = "Une mise à jour est disponible" & vbNewLine & vbNewLine & "Cliquez sur 'New update avaible'" & vbNewLine & "pour télécharger la nouvelle version"
                    fdialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                    fdialog.Label1.Text = "Ein Update ist verfügbar" & vbNewLine & vbNewLine & "Klicken Sie auf 'New update avaible'" & vbNewLine & "um eine neue Version herunterzuladen"
                    fdialog.ShowDialog()
                End If
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Label1.Text = "An error has occurred when checking updates" & vbNewLine & "Check if you are connected to internet"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Label1.Text = "Une erreur est survenue lors de la vérification des mises à jour" & vbNewLine & "Vérifiez que vous êtes connecté à internet"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                fdialog.Label1.Text = "Beim Überprüfen der Updates ist ein Fehler aufgetreten." & vbNewLine & "Überprüfen Sie, ob Sie mit dem Internet verbunden sind."
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Checkupdates()
    End Sub

    Private Sub NCSE_logo_update_Click(sender As Object, e As EventArgs) Handles NCSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/3ds-Nintendogs-cats-Save-Editor/releases")
    End Sub
End Class
