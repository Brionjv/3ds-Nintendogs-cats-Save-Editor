Imports PackageIO
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
                Makesysdatabackup()
                Readsysdata()
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

    Public Sub Makesysdatabackup()
        Try
            My.Computer.FileSystem.CopyFile(
          sysdata,
        applicationpath & "\Backup\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\sysdata.dat")
            Notifications()
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                Text_done.Text = "Backup done !"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
                Text_done.Text = "Backup effectué !"
            ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
                Text_done.Text = "Backup fertig !"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Notifications()
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_done.Text = "It's done !"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_done.Text = "C'est fait !"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(2) Then
            Text_done.Text = "Es ist fertig !"
        End If
        Panel_done.Visible = True
        Timer_done.Start()
    End Sub

    Private Sub Timer_done_Tick(sender As Object, e As EventArgs) Handles Timer_done.Tick
        Timer_done.Stop()
        Panel_done.Visible = False
    End Sub

    Private Sub Panel_done_VisibleChanged(sender As Object, e As EventArgs) Handles Panel_done.VisibleChanged
        If Panel_done.Visible = False Then
            Icon_description.Visible = False
        ElseIf Panel_done.Visible = True Then
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
            End Try
        End If
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
    'end settings

    Public Sub Readsysdata()
        Dim Reader As New PackageIO.Reader(sysdata, PackageIO.Endian.Little)
        Try
            TextBox_fpath.Text = sysdata
            Text_menu_save.Visible = True
        Catch ex As Exception

        End Try
    End Sub
End Class
