Imports PackageIO
Imports System.ComponentModel
Imports System.IO
Imports System.Net

Public Class Form1
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim sysdata As String
    Dim Ownerpts = &H9C
    Dim Money = &HA0
    Dim Inventory = &HA4
    Dim houseinterior = &H207
    Dim Ist_animal = &H2AC
    Dim Ist_cat = &H4A2
    Dim Ist_dog = &H4AA
    Dim IInd_animal = &H1EAC
    Dim IInd_cat = &H20A2
    Dim IInd_dog = &H20AA
    Dim IIIrd_animal = &H3AAC
    Dim IIIrd_cat = &H3CA2
    Dim IIIrd_dog = &H3CAA
    Dim IVth_animal = &H56AC
    Dim IVth_cat = &H58A2
    Dim IVth_dog = &H58AA
    Dim Vth_animal = &H72AC
    Dim Vth_cat = &H74A2
    Dim Vth_dog = &H74AA
    Dim VIth_animal = &H8EAC
    Dim VIth_cat = &H90A2
    Dim VIth_dog = &H90AA

    'menu
    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub TLSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_title.MouseDown, TLSE_header.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub TLSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_title.MouseUp, TLSE_header.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TLSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_title.MouseMove, TLSE_header.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Minimizebutton_Click(sender As Object, e As EventArgs) Handles Minimizebutton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimizebutton_MouseMove(sender As Object, e As MouseEventArgs) Handles Minimizebutton.MouseMove
        Minimizebutton.Image = My.Resources.minimize_gray
    End Sub

    Private Sub Minimizebutton_MouseLeave(sender As Object, e As EventArgs) Handles Minimizebutton.MouseLeave
        Minimizebutton.Image = My.Resources.minimize
    End Sub

    Private Sub Icon_MiitopiaSE_Click(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.Click
        Process.Start("https://github.com/Brionjv/Miitopia-Save-Editor/releases")
    End Sub

    Private Sub Icon_MiitopiaSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.MouseLeave
        Icon_MiitopiaSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_MiitopiaSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_MiitopiaSE.MouseMove
        Icon_MiitopiaSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Miitopia Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Miitopia Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier zum Herunterladen und versuchen Sie es mit Miitopia Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_ChibiRoboZLSE_Click(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.Click
        Process.Start("https://github.com/Brionjv/Chibi-Robo-ZL-Save-Editor/releases")
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.MouseLeave
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_ChibiRoboZLSE.MouseMove
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Chibi Robo zip Lash Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Chibi Robo zip Lash Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier zum Herunterladen und versuchen Sie es mit Chibi Robo zip Lash Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_PaparMarioSSSE_Click(sender As Object, e As EventArgs) Handles Icon_PaparMarioSSSE.Click
        Process.Start("https://github.com/Brionjv/Paper-Mario-SS-Save-Editor/releases")
    End Sub

    Private Sub Icon_PaparMarioSSSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_PaparMarioSSSE.MouseLeave
        Icon_PaparMarioSSSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_PaparMarioSSSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_PaparMarioSSSE.MouseMove
        Icon_PaparMarioSSSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Paper Mario Sticker Star Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Paper Mario Sticker Star Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier zum Herunterladen und versuchen Sie es mit Paper Mario Sticker Star Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_IronfallISE_Click(sender As Object, e As EventArgs) Handles Icon_IronfallISE.Click
        Process.Start("https://github.com/Brionjv/Ironfall-Invasion-Save-Editor/releases")
    End Sub

    Private Sub Icon_IronfallISE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_IronfallISE.MouseLeave
        Icon_IronfallISE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_IronfallISE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_IronfallISE.MouseMove
        Icon_IronfallISE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Ironfall Invasion Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Ironfall Invasion Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier zum Herunterladen und versuchen Sie es mit Ironfall Invasion Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_MarioPartyITSE_Click(sender As Object, e As EventArgs) Handles Icon_MarioPartyITSE.Click
        Process.Start("https://github.com/Brionjv/Mario-Party-IT-Save-Editor/releases")
    End Sub

    Private Sub Icon_MarioPartyITSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MarioPartyITSE.MouseLeave
        Icon_MarioPartyITSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_MarioPartyITSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_MarioPartyITSE.MouseMove
        Icon_MarioPartyITSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Mario Party Island Tour Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Mario Party Island Tour Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier zum Herunterladen und versuchen Sie es mit Mario Party Island Tour Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_3dsSEL_Click(sender As Object, e As EventArgs) Handles Icon_3dsSEL.Click
        Process.Start("https://github.com/Brionjv/3DS-Save-Editors-Library/releases")
    End Sub

    Private Sub Icon_3dsSEL_MouseLeave(sender As Object, e As EventArgs) Handles Icon_3dsSEL.MouseLeave
        Icon_3dsSEL.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_3dsSEL_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_3dsSEL.MouseMove
        Icon_3dsSEL.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try 3DS Save Editors Library (Collection of little save editors)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer 3DS Save Editors Library (Collection de petit éditeurs de sauvegarde)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier zum Herunterladen und versuchen Sie es mit 3DS Save Editors Library (Sammlung kleiner Save-Editoren)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Text_OtherSE_Click(sender As Object, e As EventArgs) Handles Text_OtherSE.Click
        Process.Start("https://github.com/Brionjv?tab=repositories")
    End Sub

    Private Sub Text_OtherSE_MouseLeave(sender As Object, e As EventArgs) Handles Text_OtherSE.MouseLeave
        Text_OtherSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Text_OtherSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_OtherSE.MouseMove
        Text_OtherSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to see all save editors"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour voir tout les éditeurs de sauvegarde"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier, um alle Editoren zum Speichern anzuzeigen"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_TLSE_Click(sender As Object, e As EventArgs) Handles Icon_TLSE.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Private Sub Icon_TLSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_TLSE.MouseLeave
        Icon_TLSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_TLSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_TLSE.MouseMove
        Icon_TLSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Tomodachi Life Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Tomodachi Life Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier zum Herunterladen und versuchen Sie es mit Tomodachi Life Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_ZALBWSE_Click(sender As Object, e As EventArgs) Handles Icon_ZALBWSE.Click
        Process.Start("https://github.com/Brionjv/TLOZ-A-Link-Between-Worlds-Save-Editor/releases")
    End Sub

    Private Sub Icon_ZALBWSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_ZALBWSE.MouseLeave
        Icon_ZALBWSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_ZALBWSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_ZALBWSE.MouseMove
        Icon_ZALBWSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try The Legend of Zelda : A Link Between Worlds Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer The Legend of Zelda : A Link Between Worlds Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier zum Herunterladen und versuchen Sie es mit The Legend of Zelda : A Link Between Worlds Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_NCSE_gbt_Click(sender As Object, e As EventArgs) Handles Icon_NCSE_gbt.Click
        Process.Start("https://gbatemp.net/threads/release-3ds-nintendogs-cats-save-editor.473694/")
    End Sub

    Private Sub Icon_NCSE_gbt_MouseLeave(sender As Object, e As EventArgs) Handles Icon_NCSE_gbt.MouseLeave
        Icon_NCSE_gbt.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_NCSE_gbt_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_NCSE_gbt.MouseMove
        Icon_NCSE_gbt.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to access to 3DS Nintendog's + cats Save Editor page (gbatemp.net)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour à la page de 3DS Nintendog's + cats Save Editor (gbatemp.net)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier, um zur Seite 3DS Nintendogs + cats Save Editor zu gelangen (gbatemp.net)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_NCSE_git_Click(sender As Object, e As EventArgs) Handles Icon_NCSE_git.Click
        Process.Start("https://github.com/Brionjv/3ds-Nintendogs-cats-Save-Editor/releases")
    End Sub

    Private Sub Icon_NCSE_git_MouseLeave(sender As Object, e As EventArgs) Handles Icon_NCSE_git.MouseLeave
        Icon_NCSE_git.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_NCSE_git_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_NCSE_git.MouseMove
        Icon_NCSE_git.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to access to 3DS Nintendog's + cats Save Editor page (Github)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour à la page de 3DS Nintendog's + cats Save Editor (Github)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_description.Text = "Klicken Sie hier, um zur Seite 3DS Nintendogs + cats Save Editor zu gelangen (Github)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Menu_text_settings_Click(sender As Object, e As EventArgs) Handles Menu_text_settings.Click, Menu_settings.Click
        Hidepanels()
        Hideselectmenu()
        Panel_settings.Visible = True
    End Sub

    Private Sub Menu_text_settings_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_settings.MouseMove, Menu_settings.MouseMove
        Menu_settings.BackgroundImage = My.Resources.Icon_act_button
    End Sub

    Private Sub Menu_text_settings_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_settings.MouseLeave, Menu_settings.MouseLeave
        If Panel_settings.Visible = True Then
            Menu_settings.BackgroundImage = My.Resources.Icon_act_button
        Else
            Menu_settings.BackgroundImage = My.Resources.Icon_unact_button
        End If
    End Sub

    Private Sub Menu_text_main_Click(sender As Object, e As EventArgs) Handles Menu_text_main.Click, Menu_main.Click
        Hidepanels()
        Hideselectmenu()
        Panel_main.Visible = True
    End Sub

    Private Sub Menu_text_main_MouseMove(sender As Object, e As MouseEventArgs) Handles Menu_text_main.MouseMove, Menu_main.MouseMove
        Menu_main.BackgroundImage = My.Resources.Icon_act_button
    End Sub

    Private Sub Menu_text_main_MouseLeave(sender As Object, e As EventArgs) Handles Menu_text_main.MouseLeave, Menu_main.MouseLeave
        If Panel_main.Visible = True Then
            Menu_main.BackgroundImage = My.Resources.Icon_act_button
        Else
            Menu_main.BackgroundImage = My.Resources.Icon_unact_button
        End If
    End Sub

    Public Sub Hidepanels()
        Panel_main.Visible = False
        Panel_inventory.Visible = False
        Panel_settings.Visible = False
    End Sub

    Public Sub Hideselectmenu()
        Menu_main.BackgroundImage = My.Resources.Icon_unact_button
        Menu_settings.BackgroundImage = My.Resources.Icon_unact_button
    End Sub

    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Try
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "3DS Nintendog's + cats Save Editor will make a backup of your save file in case" & vbNewLine & "If you are troubles, you can restore your older save file in 'Backup' folder in save editor location"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "3DS Nintendog's + cats Save Editor va faire une copie de votre sauvegarde au cas où" & vbNewLine & "Si vous avez un problème, vous pouvez restaurer votre ancien fichier de sauvegarde dans le dossier 'Backup' à l'emplacement de l'éditeur de sauvegarde"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "3DS Nintendogs + cats Save Editor erstellt für den Fall eine Sicherungskopie Ihrer Sicherungsdatei" & vbNewLine & "Wenn Sie Probleme haben, können Sie Ihre ältere Sicherungsdatei im Ordner ''Backup'' im Speicherort des Sicherungseditors wiederherstellen"
            End If
            NCSE_dialog.ShowDialog()
            Dim open As New OpenFileDialog
            open.Filter = "DAT files|*.dat"
            open.Title = "Open save sysdata.dat"
            open.ShowDialog()
            sysdata = open.FileName
        Catch ex As Exception
        End Try
        Try
            If FileLen(sysdata) = &HEE08 Then
                Readsysdata()
                Makesysdatabackup()
            Else
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    NCSE_dialog.Text_NCSE_dialog.Text = "Invalid Nintendog's + cats save file"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    NCSE_dialog.Text_NCSE_dialog.Text = "Sauvegarde Nintendog's + cats invalide"
                ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
                    NCSE_dialog.Text_NCSE_dialog.Text = "Ungültige Nintendogs + cats Speicherdatei"
                End If
                NCSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        Savesysdata()
    End Sub

    Private Sub Text_menu_save_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_save.MouseMove
        Panel_menu_opensave.BackgroundImage = My.Resources.Icon_act_button
    End Sub

    Private Sub Text_menu_save_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_save.MouseLeave
        Panel_menu_opensave.BackgroundImage = My.Resources.Icon_unact_button
    End Sub

    Private Sub Text_menu_open_MouseMove(sender As Object, e As MouseEventArgs) Handles Text_menu_open.MouseMove
        Panel_menu_opensave.BackgroundImage = My.Resources.Icon_act_button
    End Sub

    Private Sub Text_menu_open_MouseLeave(sender As Object, e As EventArgs) Handles Text_menu_open.MouseLeave
        Panel_menu_opensave.BackgroundImage = My.Resources.Icon_unact_button
    End Sub

    Public Sub Makesysdatabackup()
        Try
            My.Computer.FileSystem.CopyFile(
          sysdata,
        applicationpath & "\Backup\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\sysdata.dat")
            Notifications()
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                Text_notifications.Text = "Backup done !"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                Text_notifications.Text = "Backup effectué !"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
                Text_notifications.Text = "Backup fertig !"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Notifications()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_notifications.Text = "It's done !"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_notifications.Text = "C'est fait !"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_notifications.Text = "Es ist fertig !"
        End If
        Panel_notifications.Visible = True
        Timer_notifications.Start()
    End Sub

    Private Sub Timer_notifications_Tick(sender As Object, e As EventArgs) Handles Timer_notifications.Tick
        Timer_notifications.Stop()
        Panel_notifications.Visible = False
    End Sub

    Private Sub Panel_notifications_VisibleChanged(sender As Object, e As EventArgs) Handles Panel_notifications.VisibleChanged
        If Panel_notifications.Visible = False Then
            Icon_description.Visible = False
        ElseIf Panel_notifications.Visible = True Then
            Icon_description.Visible = True
        End If
    End Sub

    Public Sub Checkupdates()
        If Setting_ckupdate.Checked = False Then
            Try
                Dim MAJ As New WebClient
                Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/3ds-Nintendogs-cats-Save-Editor/master/Version.txt")
                If Text_NCSE_version.Text = lastupdate Then
                    NCSE_logo.Visible = True
                    NCSE_logo_update.Visible = False
                Else
                    NCSE_logo.Visible = False
                    NCSE_logo_update.Visible = True
                    If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                        NCSE_dialog.Text_NCSE_dialog.Text = "An update is available" & vbNewLine & vbNewLine & "Click on 3DS Nintendog's + cats Save Editor icon" & vbNewLine & "to download new version"
                        NCSE_dialog.ShowDialog()
                    End If
                    If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                        NCSE_dialog.Text_NCSE_dialog.Text = "Une mise à jour est disponible" & vbNewLine & vbNewLine & "Cliquez sur l'îcone de 3DS Nintendog's + cats Save Editor" & vbNewLine & "pour télécharger la nouvelle version"
                        NCSE_dialog.ShowDialog()
                    End If
                    If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                        NCSE_dialog.Text_NCSE_dialog.Text = "Eine Aktualisierung ist verfügbar" & vbNewLine & vbNewLine & "Klicken Sie auf das 3DS Nintendog + Cats Save Editor Symbol" & vbNewLine & "um eine neue Version herunterzuladen."
                        NCSE_dialog.ShowDialog()
                    End If
                End If
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    NCSE_dialog.Text_NCSE_dialog.Text = "An error has occurred when checking updates" & vbNewLine & "Check if you are connected to internet"
                    NCSE_dialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    NCSE_dialog.Text_NCSE_dialog.Text = "Une erreur est survenue lors de la vérification des mises à jour" & vbNewLine & "Vérifiez que vous êtes connecté à internet"
                    NCSE_dialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                    NCSE_dialog.Text_NCSE_dialog.Text = "Beim Überprüfen der Updates ist ein Fehler aufgetreten." & vbNewLine & "Überprüfen Sie, ob Sie mit dem Internet verbunden sind."
                    NCSE_dialog.ShowDialog()
                End If
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Select_language.SelectedItem = Nothing Then
            Select_language.SelectedItem = Select_language.Items.Item(0)
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(0)
        End If
        Try
            Setting_Advhelp.Checked = My.Settings.Para_AdvH
            Setting_ckupdate.Checked = My.Settings.Para_chkupdate
            Setting_hidden.Checked = My.Settings.Para_hidden
            Select_language.SelectedItem = My.Settings.Para_language
            Setting_filepath.Checked = My.Settings.Para_path
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Checkupdates()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As CancelEventArgs) Handles Me.FormClosing
        My.Settings.Para_AdvH = Setting_Advhelp.Checked
        My.Settings.Para_chkupdate = Setting_ckupdate.Checked
        My.Settings.Para_hidden = Setting_hidden.Checked
        My.Settings.Para_language = Select_language.SelectedItem
        My.Settings.Para_path = Setting_filepath.Checked
    End Sub

    Private Sub NCSE_logo_update_Click(sender As Object, e As EventArgs) Handles NCSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/3ds-Nintendogs-cats-Save-Editor/releases")
    End Sub

    Private Sub Icon_filepath_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_filepath.MouseMove
        Panel_filepath.BackgroundImage = My.Resources.Icon_act_button
        TextBox_fpath.Visible = True
    End Sub

    Private Sub Icon_filepath_MouseLeave(sender As Object, e As EventArgs) Handles Icon_filepath.MouseLeave
        Panel_filepath.BackgroundImage = My.Resources.Icon_unact_button
        TextBox_fpath.Visible = False
    End Sub


    'end menu
    'settings
    Private Sub Setting_filepath_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_filepath.CheckedChanged
        If Setting_filepath.Checked = True Then
            Panel_filepath.Visible = True
        Else
            Panel_filepath.Visible = False
        End If
    End Sub

    Private Sub Setting_ckupdate_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_ckupdate.CheckedChanged
        If Setting_ckupdate.Checked = True Then
            Panel_chkupdate.Visible = True
        Else
            Panel_chkupdate.Visible = False
        End If
    End Sub

    Private Sub Setting_hidden_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_hidden.CheckedChanged
        Hiddenthings()
    End Sub

    Public Sub Hiddenthings()
        If Setting_hidden.Checked = True Then
            Panel_hiddenthings.Visible = True
            valu_homestyle.Visible = True
            Group_animal_1.Visible = True
            Group_animal_2.Visible = True
            Group_animal_3.Visible = True
            Group_animal_4.Visible = True
            Group_animal_5.Visible = True
            Group_animal_6.Visible = True
        ElseIf Setting_hidden.Checked = False Then
            Panel_hiddenthings.Visible = False
            valu_homestyle.Visible = False
            Group_animal_1.Visible = False
            Group_animal_2.Visible = False
            Group_animal_3.Visible = False
            Group_animal_4.Visible = False
            Group_animal_5.Visible = False
            Group_animal_6.Visible = False
        End If
    End Sub

    Private Sub Setting_Advhelp_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_Advhelp.CheckedChanged
        Advhelp()
    End Sub

    Public Sub Advhelp()
        If Setting_Advhelp.Checked = True Then
            Panel_Advhelp.Visible = True
            AdvH_allitems.Visible = True
            AdvH_animal_1.Visible = True
            AdvH_animal_2.Visible = True
            AdvH_animal_3.Visible = True
            AdvH_animal_4.Visible = True
            AdvH_animal_5.Visible = True
            AdvH_animal_6.Visible = True
            AdvH_homestyle.Visible = True
            AdvH_money.Visible = True
            AdvH_trainerpoints.Visible = True
        ElseIf Setting_Advhelp.Checked = False Then
            Panel_Advhelp.Visible = False
            AdvH_allitems.Visible = False
            AdvH_animal_1.Visible = False
            AdvH_animal_2.Visible = False
            AdvH_animal_3.Visible = False
            AdvH_animal_4.Visible = False
            AdvH_animal_5.Visible = False
            AdvH_animal_6.Visible = False
            AdvH_homestyle.Visible = False
            AdvH_money.Visible = False
            AdvH_trainerpoints.Visible = False
        End If
    End Sub

    Public Sub Switchlanguage()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_menu_open.Text = "Open"
            Text_menu_save.Text = "Save"
            Menu_text_main.Text = "Main"
            Menu_text_settings.Text = "Settings"
            Title_animal_1.Text = "1st animal"
            Title_animal_2.Text = "2nd animal"
            Title_animal_3.Text = "3rd animal"
            Title_animal_4.Text = "4th animal"
            Title_animal_5.Text = "5th animal"
            Title_animal_6.Text = "6th animal"
            Title_homestyle.Text = "Home style"
            Group_animal_1.Text = "My 1st animal is a :"
            Group_animal_2.Text = "My 2nd animal is a :"
            Group_animal_3.Text = "My 3rd animal is a :"
            Group_animal_4.Text = "My 4th animal is a :"
            Group_animal_5.Text = "My 5th animal is a :"
            Group_animal_6.Text = "My 6th animal is a :"
            Check_cat_1.Text = "Cat"
            Check_cat_2.Text = "Cat"
            Check_cat_3.Text = "Cat"
            Check_cat_4.Text = "Cat"
            Check_cat_5.Text = "Cat"
            Check_cat_6.Text = "Cat"
            Check_dog_1.Text = "Dog"
            Check_dog_2.Text = "Dog"
            Check_dog_3.Text = "Dog"
            Check_dog_4.Text = "Dog"
            Check_dog_5.Text = "Dog"
            Check_dog_6.Text = "Dog"
            Check_trainerpoints.Text = "Get trainer points as maximum"
            Check_allitems.Text = "Get all items"
            Setting_hidden.Text = "Show hidden things"
            Setting_filepath.Text = "Show file path"
            Setting_Advhelp.Text = "Show advance help"
            Setting_ckupdate.Text = "Unactive check updates"
            Text_language.Text = "Language :"
            Settings_settings.Text = "Settings"
            Settings_credits.Text = "Credits"
            Settings_changelog.Text = "Changelog"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_menu_open.Text = "Ouvrir"
            Text_menu_save.Text = "Enregistrer"
            Menu_text_main.Text = "Principal"
            Menu_text_settings.Text = "Paramètres"
            Title_animal_1.Text = "1er animal"
            Title_animal_2.Text = "2ème animal"
            Title_animal_3.Text = "3ème animal"
            Title_animal_4.Text = "4ème animal"
            Title_animal_5.Text = "5ème animal"
            Title_animal_6.Text = "6ème animal"
            Title_homestyle.Text = "Style maison"
            Group_animal_1.Text = "Mon 1er animal est un:"
            Group_animal_2.Text = "Mon 2ème animal est un:"
            Group_animal_3.Text = "Mon 3ème animal est un:"
            Group_animal_4.Text = "Mon 4ème animal est un:"
            Group_animal_5.Text = "Mon 5ème animal est un:"
            Group_animal_6.Text = "Mon 6ème animal est un:"
            Check_cat_1.Text = "Chat"
            Check_cat_2.Text = "Chat"
            Check_cat_3.Text = "Chat"
            Check_cat_4.Text = "Chat"
            Check_cat_5.Text = "Chat"
            Check_cat_6.Text = "Chat"
            Check_dog_1.Text = "Chien"
            Check_dog_2.Text = "Chien"
            Check_dog_3.Text = "Chien"
            Check_dog_4.Text = "Chien"
            Check_dog_5.Text = "Chien"
            Check_dog_6.Text = "Chien"
            Check_trainerpoints.Text = "Mettre les points d'entraîneur au maximum"
            Check_allitems.Text = "Obtenir tous les objets"
            Setting_hidden.Text = "Afficher les choses cachées"
            Setting_filepath.Text = "Afficher le chemin du fichier"
            Setting_Advhelp.Text = "Afficher l'aide avancée"
            Setting_ckupdate.Text = "Désactiver la vérification de Mises à jour"
            Text_language.Text = "Langue:"
            Settings_settings.Text = "Paramètres"
            Settings_credits.Text = "Crédits"
            Settings_changelog.Text = "Changelog"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_menu_open.Text = "Öffnen"
            Text_menu_save.Text = "Speichern"
            Menu_text_main.Text = "Main"
            Menu_text_settings.Text = "Einstellungen"
            Title_animal_1.Text = "1. Tier"
            Title_animal_2.Text = "2. Tier"
            Title_animal_3.Text = "3. Tier"
            Title_animal_4.Text = "4. Tier"
            Title_animal_5.Text = "5. Tier"
            Title_animal_6.Text = "6. Tier"
            Title_homestyle.Text = "Heimatstil"
            Group_animal_1.Text = "Mein 1. Tier ist ein:"
            Group_animal_2.Text = "Mein 2. Tier ist ein:"
            Group_animal_3.Text = "Mein 3. Tier ist ein:"
            Group_animal_4.Text = "Mein 4. Tier ist ein:"
            Group_animal_5.Text = "Mein 5. Tier ist ein:"
            Group_animal_6.Text = "Mein 6. Tier ist ein:"
            Check_cat_1.Text = "Katze"
            Check_cat_2.Text = "Katze"
            Check_cat_3.Text = "Katze"
            Check_cat_4.Text = "Katze"
            Check_cat_5.Text = "Katze"
            Check_cat_6.Text = "Katze"
            Check_dog_1.Text = "Hund"
            Check_dog_2.Text = "Hund"
            Check_dog_3.Text = "Hund"
            Check_dog_4.Text = "Hund"
            Check_dog_5.Text = "Hund"
            Check_dog_6.Text = "Hund"
            Check_trainerpoints.Text = "Holen Sie sich Trainerpunkte als Maximum"
            Check_allitems.Text = "Alle Elemente abrufen"
            Setting_hidden.Text = "Versteckte Dinge anzeigen"
            Setting_filepath.Text = "Dateipfad anzeigen"
            Setting_Advhelp.Text = "Erweiterte Hilfe anzeigen"
            Setting_ckupdate.Text = "Updates nicht aktiv prüfen"
            Text_language.Text = "Sprache:"
            Settings_settings.Text = "Einstellungen"
            Settings_credits.Text = "Credits"
            Settings_changelog.Text = "Änderungsprotokoll"
        End If
    End Sub

    Private Sub Select_language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_language.SelectedIndexChanged
        Switchlanguage()
    End Sub
    'end settings
    'main
    Public Sub Readsysdata()
        Dim Reader As New PackageIO.Reader(sysdata, PackageIO.Endian.Little)
        Try
            Reader.Position = Money
            valu_money.Value = Reader.ReadUInt32
            Reader.Position = houseinterior
            valu_homestyle.Value = Reader.ReadByte
            Reader.Position = Ist_animal
            Text_animal_1.Text = Reader.ReadUnicodeString(10)
            Reader.Position = IInd_animal
            Text_animal_2.Text = Reader.ReadUnicodeString(10)
            Reader.Position = IIIrd_animal
            Text_animal_3.Text = Reader.ReadUnicodeString(10)
            Reader.Position = IVth_animal
            Text_animal_4.Text = Reader.ReadUnicodeString(10)
            Reader.Position = Vth_animal
            Text_animal_5.Text = Reader.ReadUnicodeString(10)
            Reader.Position = VIth_animal
            Text_animal_6.Text = Reader.ReadUnicodeString(10)
            TextBox_fpath.Text = sysdata
            Text_menu_save.Visible = True
        Catch ex As Exception
            Text_menu_save.Visible = False
        End Try
    End Sub

    Public Sub Savesysdata()
        Unlockallitems()
        Maxtrainerspoints()
        edithiddennames()
        Try
            Dim Writer As New PackageIO.Writer(sysdata, PackageIO.Endian.Little)
            Writer.Position = Money
            Writer.WriteUInt32(valu_money.Value)
            For i As Integer = 0 To 19
                Writer.Position = Ist_animal + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Ist_animal
            Writer.WriteUnicodeString(Text_animal_1.Text)
            For i As Integer = 0 To 19
                Writer.Position = IInd_animal + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = IInd_animal
            Writer.WriteUnicodeString(Text_animal_2.Text)
            For i As Integer = 0 To 19
                Writer.Position = IIIrd_animal + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = IIIrd_animal
            Writer.WriteUnicodeString(Text_animal_3.Text)
            For i As Integer = 0 To 19
                Writer.Position = IVth_animal + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = IVth_animal
            Writer.WriteUnicodeString(Text_animal_4.Text)
            For i As Integer = 0 To 19
                Writer.Position = Vth_animal + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Vth_animal
            Writer.WriteUnicodeString(Text_animal_5.Text)
            For i As Integer = 0 To 19
                Writer.Position = VIth_animal + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = VIth_animal
            Writer.WriteUnicodeString(Text_animal_6.Text)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "Failed to edit sysdata.dat"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "L'édition de sysdata.dat à échoué"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "sysdata.dat konnte nicht bearbeitet werden"
                NCSE_dialog.ShowDialog()
            End If
        End Try
        Try
            Dim ws As New FileStream(sysdata, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            ws.Position = houseinterior
            ws.WriteByte(valu_homestyle.Value)
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "Failed to edit home style"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "L'édition du style de l'intérieur à échoué"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "Home-Stil könnte nicht bearbeitet werden"
                NCSE_dialog.ShowDialog()
            End If
        End Try
        Notifications()
    End Sub

    Private Sub Fea_money_Click(sender As Object, e As EventArgs) Handles Fea_money.Click
        valu_money.Value = valu_money.Maximum
    End Sub

    Private Sub valu_homestyle_ValueChanged(sender As Object, e As EventArgs) Handles valu_homestyle.ValueChanged
        If valu_homestyle.Value = 0 Then
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(0)
        ElseIf valu_homestyle.Value = 1 Then
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(1)
        ElseIf valu_homestyle.Value = 2 Then
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(2)
        ElseIf valu_homestyle.Value = 3 Then
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(3)
        ElseIf valu_homestyle.Value = 4 Then
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(4)
        ElseIf valu_homestyle.Value = 5 Then
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(5)
        ElseIf valu_homestyle.Value = 6 Then
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(6)
        ElseIf valu_homestyle.Value = 7 Then
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(7)
        ElseIf valu_homestyle.Value = 8 Then
            Select_homestyle.SelectedItem = Select_homestyle.Items.Item(8)
        End If
    End Sub

    Private Sub Select_homestyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_homestyle.SelectedIndexChanged
        If Select_homestyle.SelectedItem = Select_homestyle.Items.Item(0) Then
            valu_homestyle.Value = 0
        ElseIf Select_homestyle.SelectedItem = Select_homestyle.Items.Item(1) Then
            valu_homestyle.Value = 1
        ElseIf Select_homestyle.SelectedItem = Select_homestyle.Items.Item(2) Then
            valu_homestyle.Value = 2
        ElseIf Select_homestyle.SelectedItem = Select_homestyle.Items.Item(3) Then
            valu_homestyle.Value = 3
        ElseIf Select_homestyle.SelectedItem = Select_homestyle.Items.Item(4) Then
            valu_homestyle.Value = 4
        ElseIf Select_homestyle.SelectedItem = Select_homestyle.Items.Item(5) Then
            valu_homestyle.Value = 5
        ElseIf Select_homestyle.SelectedItem = Select_homestyle.Items.Item(6) Then
            valu_homestyle.Value = 6
        ElseIf Select_homestyle.SelectedItem = Select_homestyle.Items.Item(7) Then
            valu_homestyle.Value = 7
        ElseIf Select_homestyle.SelectedItem = Select_homestyle.Items.Item(8) Then
            valu_homestyle.Value = 8
        End If
    End Sub

    Public Sub Unlockallitems()
        Try
            If Check_allitems.Checked = True Then
                Dim Writer As New PackageIO.Writer(sysdata, PackageIO.Endian.Little)
                For i As Integer = 0 To 354
                    Writer.Position = Inventory + i
                    Writer.WriteInt8(valu_allitems.Value)
                Next
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "Failed to edit items"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "L'édition des objets à échoué"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "Elemente konnten nicht bearbeitet werden"
                NCSE_dialog.ShowDialog()
            End If
            Check_allitems.Checked = False
        End Try
    End Sub

    Public Sub Maxtrainerspoints()
        Try
            If Check_trainerpoints.Checked = True Then
                Dim Writer As New PackageIO.Writer(sysdata, PackageIO.Endian.Little)
                Writer.Position = Ownerpts
                Writer.WriteUInt32(1203982208)
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "Failed to edit owner points"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "L'édition des points d'entraîneur à échoué"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "Eigentümerpunkte konnten nicht bearbeitet werden"
                NCSE_dialog.ShowDialog()
            End If
            Check_trainerpoints.Checked = False
        End Try
    End Sub

    Public Sub edithiddennames()
        Dim Writer As New PackageIO.Writer(sysdata, PackageIO.Endian.Little)
        Try
            If Check_dog_1.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = Ist_dog + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Ist_dog
                Writer.WriteUnicodeString(Text_animal_1.Text)
            End If
            If Check_cat_1.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = Ist_cat + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Ist_cat
                Writer.WriteUnicodeString(Text_animal_1.Text)
            End If
            If Check_dog_2.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = IInd_dog + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = IInd_dog
                Writer.WriteUnicodeString(Text_animal_2.Text)
            End If
            If Check_cat_2.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = IInd_cat + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = IInd_cat
                Writer.WriteUnicodeString(Text_animal_2.Text)
            End If
            If Check_dog_3.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = IIIrd_dog + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = IIIrd_dog
                Writer.WriteUnicodeString(Text_animal_3.Text)
            End If
            If Check_cat_3.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = IIIrd_cat + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = IIIrd_cat
                Writer.WriteUnicodeString(Text_animal_3.Text)
            End If
            If Check_dog_4.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = IVth_dog + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = IVth_dog
                Writer.WriteUnicodeString(Text_animal_4.Text)
            End If
            If Check_cat_4.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = IVth_cat + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = IVth_cat
                Writer.WriteUnicodeString(Text_animal_4.Text)
            End If
            If Check_dog_5.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = Vth_dog + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Vth_dog
                Writer.WriteUnicodeString(Text_animal_5.Text)
            End If
            If Check_cat_5.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = Vth_cat + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Vth_cat
                Writer.WriteUnicodeString(Text_animal_5.Text)
            End If
            If Check_dog_6.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = VIth_dog + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = VIth_dog
                Writer.WriteUnicodeString(Text_animal_6.Text)
            End If
            If Check_cat_6.Checked = True Then
                For i As Integer = 0 To 19
                    Writer.Position = VIth_cat + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = VIth_cat
                Writer.WriteUnicodeString(Text_animal_6.Text)
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "Failed to edit hidden names"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "L'édition des noms cachés a échoué"
                NCSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(2) Then
                NCSE_dialog.Text_NCSE_dialog.Text = "Versteckte Namen konnten nicht bearbeitet werden"
                NCSE_dialog.ShowDialog()
            End If
        End Try
    End Sub
End Class
