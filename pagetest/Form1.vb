Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Dim imageIndex As Integer = 0
    Dim images As New List(Of Bitmap)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim newLeft As Integer = CInt(screenWidth * 0.5) ' 50% 水平位置
        Dim newTop As Integer = CInt(screenHeight * 0.5) ' 50% 垂直位置
        'page1 頁面設定
        TabPage1.BackgroundImage = My.Resources.P1背景
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        StartButton.BackgroundImage = My.Resources.開始遊戲
        StartButton.BackgroundImageLayout = ImageLayout.Zoom
        GameIntro.BackgroundImage = My.Resources.遊戲介紹
        GameIntro.BackgroundImageLayout = ImageLayout.Zoom
        ExitButton.BackgroundImage = My.Resources.離開遊戲
        ExitButton.BackgroundImageLayout = ImageLayout.Zoom
        HeadLine.BackgroundImage = My.Resources.Page大標題
        StoryBook.BackgroundImage = My.Resources.book
        StoryBook.BackgroundImageLayout = ImageLayout.Zoom
        MISTeacher.BackgroundImageLayout = ImageLayout.Zoom
        StartButton.Height = 100
        StartButton.Width = 350
        StartButton.Top = screenHeight / 2 - 5
        StartButton.Left = screenWidth / 2 - StartButton.Width / 2
        GameIntro.Height = 100
        GameIntro.Width = 350
        GameIntro.Top = StartButton.Top + StartButton.Height + 30
        GameIntro.Left = screenWidth / 2 - StartButton.Width / 2
        ExitButton.Height = 100
        ExitButton.Width = 350
        ExitButton.Top = GameIntro.Top + GameIntro.Height + 30
        ExitButton.Left = screenWidth / 2 - StartButton.Width / 2
        StoryBook.Height = 150
        StoryBook.Width = 150
        StoryBook.Top = 0
        StoryBook.Left = screenWidth - 170
        HeadLine.Height = 400
        HeadLine.Width = 800
        HeadLine.Top = screenHeight / 100
        HeadLine.Left = screenWidth / 2 - HeadLine.Width / 2
        MISTeacher.Height = 150
        MISTeacher.Width = 150
        MISTeacher.Top = HeadLine.Height / 2 - 25
        MISTeacher.Left = HeadLine.Right - 142
        '音效設定
        AxWindowsMediaPlayer1.settings.autoStart = True
        AxWindowsMediaPlayer2.settings.autoStart = False
        AxWindowsMediaPlayer1.Visible = False
        AxWindowsMediaPlayer1.settings.setMode("loop", True)
        AxWindowsMediaPlayer1.settings.volume = 10
        AxWindowsMediaPlayer1.URL = "C:\Users\jie84\OneDrive\Desktop\教授大戰\教授大戰\教授大戰\pagetest\Resources\electronic-rock-king-around-here-15045.wav"
        Music.Tag = "ON"
        Music.BackgroundImage = My.Resources._ON
        Music.BackgroundImageLayout = ImageLayout.Zoom
        Music.Width = StoryBook.Width - 50
        Music.Height = StoryBook.Height - 50
        Music.Top = ExitButton.Top
        Music.Left = StoryBook.Left
        AxWindowsMediaPlayer2.URL = "C:\Users\jie84\OneDrive\Desktop\教授大戰\教授大戰\教授大戰\pagetest\Resources\risk-136788.wav"
        AxWindowsMediaPlayer2.Visible = False
        AxWindowsMediaPlayer2.settings.setMode("loop", True)
        AxWindowsMediaPlayer2.settings.volume = 10

        AxWindowsMediaPlayer3.settings.autoStart = False
        AxWindowsMediaPlayer3.Visible = False
        AxWindowsMediaPlayer3.settings.volume = 25
        AxWindowsMediaPlayer3.URL = "C:\Users\jie84\OneDrive\Desktop\教授大戰\教授大戰\教授大戰\pagetest\Resources\explosion.wav"
        AxWindowsMediaPlayer4.settings.autoStart = False
        AxWindowsMediaPlayer4.Visible = False
        AxWindowsMediaPlayer4.settings.volume = 15
        AxWindowsMediaPlayer4.URL = "C:\Users\jie84\OneDrive\Desktop\教授大戰\教授大戰\教授大戰\pagetest\Resources\投擲.wav"

        Music2.Top = ExitButton.Top
        Music2.Left = StoryBook.Left
        Music2.Tag = "ON"
        Music2.BackgroundImageLayout = ImageLayout.Zoom
        Music2.BackgroundImage = My.Resources._ON
        Music2.Width = StoryBook.Width - 50
        Music2.Height = StoryBook.Height - 50

        '動態物件
        images.Add(My.Resources.董合身1)
        images.Add(My.Resources.董合身2)
        images.Add(My.Resources.董合身3)
        images.Add(My.Resources.董合身4)
        images.Add(My.Resources.董合身5)
        P1BackgroundTimer.Interval = 50
        P1BackgroundTimer.Start()
        'page2 物件位置設定
        Me.TabPage2.BackgroundImage = My.Resources._249
        Me.TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        Button3.TextAlign = ContentAlignment.MiddleCenter
        PictureBox5.BackColor = Color.Transparent

        Label2.Left = newLeft - Label2.Left * 8
        Label2.Top = newTop - 175
        ComboBox1.Left = newLeft - ComboBox1.Left * 8 + 20
        ComboBox1.Top = newTop - 140
        PictureBox1.Left = newLeft - 250
        PictureBox1.Top = newTop - 350
        Label3.Left = newLeft - Label3.Left * 8
        Label3.Top = newTop - 50
        ComboBox2.Left = newLeft - ComboBox2.Left * 8 + 40
        ComboBox2.Top = newTop
        Label1.Left = newLeft + Label1.Left - 70
        Label1.Top = newTop - 380
        PictureBox5.Left = newLeft + PictureBox5.Left - 250
        PictureBox5.Top = newTop - 350
        'PictureBox5.BorderStyle = BorderStyle.Fixed3D'
        'ListBox1.Left = newLeft + ListBox1.Left - 150
        ' PictureBox5.Left = newLeft + PictureBox5.Left - 350
        Button2.Width = 140
        Button2.Height = 50
        Button2.Left = newLeft + Button2.Left
        Button2.Top = newTop + 100
        Button3.Width = 140
        Button3.Height = 50
        Button3.Left = newLeft + Button3.Left
        Button3.Top = newTop + 180

        Me.WindowState = FormWindowState.Maximized
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

        'TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.Dock = DockStyle.Fill
        ComboBox1.SelectedIndex = 0
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        'page3設定
        Player.Top = screenHeight - screenHeight * 0.35
        Player.Left = screenWidth / 14
        Player.Width = 200
        Player.Height = 150
        Enemy.Top = Player.Top
        Enemy.Left = screenWidth * 0.73
        Enemy.Width = Player.Width
        Enemy.Height = Player.Height
        PlayerWeapon.Top = Player.Top
        PlayerWeapon.Left = Player.Right - screenWidth / 47
        PlayerWeapon.Width = 50
        PlayerWeapon.Height = 50
        PlayerWeapon.BringToFront()
        EnemyWeapon.Top = Enemy.Top
        EnemyWeapon.Left = Enemy.Left - EnemyWeapon.Width + screenWidth / 47
        EnemyWeapon.Width = PlayerWeapon.Width
        EnemyWeapon.Height = PlayerWeapon.Height
        EnemyWeapon.BringToFront()
        TabPage3.BackgroundImage = My.Resources.P3背景
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        EnemyBlood.BackColor = Color.Blue
        EnemyBlood.Top = 30
        EnemyBlood.Left = screenWidth / 2 + 250
        EnemyBlood.Width = 400
        EnemyBlood.Height = 40
        PlayerBlood.BackColor = Color.Red
        PlayerBlood.Width = 400
        PlayerBlood.Height = 40
        PlayerBlood.Top = 30
        PlayerBlood.Left = screenWidth / 2 - 250 - PlayerBlood.Width
        skill1.Top = 300
        skill1.Left = 20
        skill1.Width = 120
        skill1.Height = 80
        skill2.Top = skill1.Top + 100
        skill2.Left = 20
        skill2.Width = 120
        skill2.Height = 80
        Finalskill.Top = skill2.Top + 100
        Finalskill.Left = 20
        Finalskill.Width = 120
        Finalskill.Height = 80
        Finalskill.Text = ""
        EnergyBar.Top = Player.Top + screenHeight * 0.1
        EnergyBar.Left = Player.Left
        EnergyBar.Width = 100
        EnergyBar.Height = 20
        EnergyPanel.Top = EnergyBar.Top
        EnergyPanel.Left = EnergyBar.Left
        EnergyPanel.Height = EnergyBar.Height
        TrackBar1.Top = EnergyBar.Top + screenWidth / 45
        TrackBar1.Left = EnergyBar.Left
        PictureBox2.Top = Player.Top - screenHeight / 10
        PictureBox2.Left = Player.Right - screenHeight / 10
        PictureBox2.Width = 300
        PictureBox2.Height = 250
        WhosTurn.Top = PlayerBlood.Top + 5
        WhosTurn.Left = (EnemyBlood.Left - PlayerBlood.Right) / 2 + PlayerBlood.Right - WhosTurn.Width / 2
        WhosTurn.BackColor = BackColor.Gray
        WhosTurn.Text = "Your Turn"
        WindWarning.Top = WhosTurn.Bottom
        WindWarning.Left = WhosTurn.Left
        WindWarning.BackColor = BackColor.SkyBlue
        playerBig.Location = New Point(1079, 0)
        enemyBig.Location = New Point(277, 0)
        TextBox1.Top = EnergyBar.Top
        TextBox1.Left = Player.Left - 50
        TextBox2.Top = EnergyBar.Top + screenWidth / 45 + 10
        TextBox2.Left = EnergyBar.Left - 50

        playerProgressBar.Width = 400
        playerProgressBar.Height = 40
        playerProgressBar.Top = 30
        playerProgressBar.Left = screenWidth / 2 - 250 - PlayerBlood.Width
        enemyProgressBar.Top = 30
        enemyProgressBar.Left = screenWidth / 2 + 250
        enemyProgressBar.Width = 400
        enemyProgressBar.Height = 40

        'TextBox4.Text = EnemyWeapon.Location.ToString()

    End Sub
    Private Sub P1_BackgroundTimer(sender As Object, e As EventArgs) Handles P1BackgroundTimer.Tick
        MISTeacher.Image = images(imageIndex)
        imageIndex += 1
        If imageIndex >= images.Count Then
            imageIndex = 0
        End If
    End Sub
    '控制跳轉page 1 ---- page 2
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        TabControl1.SelectedTab = TabControl1.TabPages(1)
    End Sub

    '控制跳轉page 2 ---- page 3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabControl1.TabPages(2)
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer2.Ctlcontrols.play()
    End Sub

    '選擇不同角色跳出不同圖片

    Public selection As Integer = 0  '0是小董 1是鱷魚
    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                PictureBox1.Image = My.Resources.董合昇_選角圖片 ' 替b换为您的图像资源或文件路径
                'page2
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage '比例顯示圖片
                PictureBox5.Image = My.Resources.介紹_1
                PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage

                Player.Image = My.Resources.董合昇_臥倒_拿電腦
                PlayerWeapon.Image = My.Resources.反向電腦
                Enemy.Image = My.Resources.拿鱷魚_右
                EnemyWeapon.Image = My.Resources.鱷魚頭
                ' Enemy.SizeMode = PictureBoxSizeMode.StretchImage

                playerBig.Image = My.Resources.管理報表
                playerBig.SizeMode = PictureBoxSizeMode.Zoom
                playerBig.Visible = False

                enemyBig.Image = My.Resources.zuvio
                enemyBig.SizeMode = PictureBoxSizeMode.Zoom
                enemyBig.Visible = False
                selection = 0

                skill1.BackgroundImage = My.Resources.飛毛腿技能
                skill1.BackgroundImageLayout = ImageLayout.Stretch
                skill2.BackgroundImage = My.Resources.報表
                skill2.BackgroundImageLayout = ImageLayout.Stretch
                Finalskill.BackgroundImage = My.Resources.大招
                Finalskill.BackgroundImageLayout = ImageLayout.Stretch
            Case 1
                PictureBox1.Image = My.Resources._2023_11_13_230535
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage '比例顯示圖片
                PictureBox5.Image = My.Resources.鱷魚介紹
                PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage

                selection = 1
                'page2 editted

                Player.Image = My.Resources.拿鱷魚_左
                PlayerWeapon.Image = My.Resources.鱷魚頭_反
                Enemy.Image = My.Resources.反向董合昇_臥倒_拿電腦
                EnemyWeapon.Image = My.Resources.電腦

                playerBig.Image = My.Resources.zuvio
                playerBig.SizeMode = PictureBoxSizeMode.Zoom
                playerBig.Visible = False

                enemyBig.Image = My.Resources.管理報表
                enemyBig.SizeMode = PictureBoxSizeMode.Zoom
                enemyBig.Visible = False

                skill1.BackgroundImage = My.Resources.約克夏技能
                skill1.BackgroundImageLayout = ImageLayout.Stretch
                skill2.BackgroundImage = My.Resources.電鋸技能
                skill2.BackgroundImageLayout = ImageLayout.Stretch
                Finalskill.BackgroundImage = My.Resources.大招
                Finalskill.BackgroundImageLayout = ImageLayout.Stretch
        End Select
    End Sub

    ' 33-97行都是用來控制蓄力條進度跟取得蓄力值
    Public powerLevel As Integer = 0
    Public front_powerLevel = 0
    Public isSpaceKeyDown As Boolean = False
    Public panelWidth As Integer = 0
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space And IfiCandownSpace Then
            isSpaceKeyDown = True
            Timer1.Start()
            Timer3.Start()
        End If

        If e.KeyCode = Keys.Up AndAlso angle <= 90 Then
            angle += 5 ' 調整的角度值，可以根據需要調整
            TextBox2.Text = angle.ToString()
            ' 更新PictureBox2的抬升效果
            UpdateElevation()

            ' 重新繪製PictureBox2以顯示新的仰角和抬升效果
            PictureBox2.Invalidate()
        ElseIf e.KeyCode = Keys.Down AndAlso angle >= 30 Then

            ' 更新PictureBox2的抬升效果
            UpdateElevation()

            ' 重新繪製PictureBox2以顯示新的仰角和抬升效果
            PictureBox2.Invalidate()

            angle -= 5 ' 調整的角度值，可以根據需要調整
            TextBox2.Text = angle.ToString()
        End If

        If e.KeyCode = Keys.Enter Then

            '用來模擬運動的計時器
            If needint <= wind Or needint = 0 Then
                MsgBox("請確認蓄力值大於風向且不為0")
                IfiCandownSpace = True
            Else
                AxWindowsMediaPlayer4.Ctlcontrols.play()
                Timer2.Start()
                Timer3.Stop()
                TurnTime = 15
                MyAttack = 20
                IfiCandownSpace = True
                If ControlTurn Mod 2 <> 0 Then
                    randomNeedint = GetRandomNeedint()
                    randomAngle = GetRandomAngle()
                Else
                    If ComboBox2.SelectedIndex <> 0 Then
                        wind = GetRandomWind()
                    Else
                        wind = 0
                    End If

                End If
                ControlTurn += 1
                WindWarning.Text = "當前風向:" & wind.ToString()
            End If
            ifCanKeySkill = True
            skill1.Enabled = True
            skill2.Enabled = True
            If BigSkill <> 0 Then
                Finalskill.Enabled = True
            Else
                Finalskill.Enabled = False
            End If
            'TextBox4.Text = MyAttack.ToString()
            Select Case ComboBox1.SelectedIndex
                Case 0
                    Enemy.Image = My.Resources.拿鱷魚_右
                    Player.Image = My.Resources.董合昇_臥倒_拿電腦
                Case 1
                    Enemy.Image = My.Resources.反向董合昇_臥倒_拿電腦
                    Player.Image = My.Resources.拿鱷魚_左
            End Select
            使用技能.Text = "使用技能:"
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Space Then
            isSpaceKeyDown = False
            IfiCandownSpace = False
            Timer1.Stop()
            powerLevel = 0
            front_powerLevel = 0
            UpdatePowerBar()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isSpaceKeyDown AndAlso powerLevel < 100 Then
            front_powerLevel = powerLevel
            powerLevel += 1
            UpdatePowerBar()
        ElseIf isSpaceKeyDown AndAlso powerLevel = 100 Then
            UpdatePowerBar()
        End If
    End Sub

    Private Shared needint As Integer = 0 '用來儲存蓄力值
    Public Sub UpdatePowerBar()
        If isSpaceKeyDown AndAlso powerLevel < 100 Then
            ' 計算Panel的寬度
            panelWidth = CInt((powerLevel - front_powerLevel) + EnergyPanel.Width)

            ' 更新Panel的寬度
            EnergyPanel.Width = panelWidth
            needint = panelWidth
        ElseIf isSpaceKeyDown AndAlso powerLevel = 100 Then
            ' 計算Panel的寬度
            panelWidth = CInt(-(powerLevel - front_powerLevel) + EnergyPanel.Width)
            ' 更新Panel的寬度
            EnergyPanel.Width = panelWidth
            needint = EnergyPanel.Width
            If EnergyPanel.Width = 0 Then
                isSpaceKeyDown = False
                IfiCandownSpace = False
            End If
        End If
        ' 設定Panel的背景色
        EnergyPanel.BackColor = Color.Blue ' 設定為藍色，您可以更改為其他顏色

        If isSpaceKeyDown = False Then
            EnergyPanel.Width = 0
            ' 設定Panel的背景色
            EnergyPanel.BackColor = Color.White ' 設定為白色，您可以更改為其他顏色
        End If
        '使用者放開空白鍵時 重製powerLevel的值
        TextBox1.Text = needint.ToString()
    End Sub
    Public isEasy As Boolean = True ' 查詢是否為簡單模式 若是 則無風力

    Public angle As Integer = 30 ' 初始仰角
    Public elevation As Integer = 0 ' 初始抬升高度
    Public velocity_X As Integer = 60 'X向 初始速度
    Public velocity_Y As Integer = 60 'Y向 初始速度
    Public timeStep As Double = 0.1 ' 時間片段
    Public isUpingNow As Boolean = True '判斷物體否處於上升階段
    Public theVelocity_YOfStart As Double ' 紀錄一開始Y方向的速度
    Public count = 0 '紀錄拋物線運動第幾次
    Public isInLowest = False '判斷是否在結束拋物線運動的最低點

    Public IfiCandownSpace As Boolean = True

    Public MyAttack As Integer = 20 '計算玩家的攻擊數值
    Public MyHP As Integer = 100 '計算玩家的生命值
    Public EnemyHP As Integer = 100 '計算敵人生命值

    Public TurnTime As Integer = 15 '限制玩家15秒內要發動攻擊
    Public ControlTurn As Integer = 1 '奇數表玩家 偶數敵人

    Public randomNeedint As Integer = GetRandomNeedint()
    Public randomAngle As Integer = GetRandomAngle()

    Public wind As Integer = GetRandomWind()

    Public ifCanKeySkill As Boolean = True
    Public BigSkill As Integer = 1

    Public LocationY_playerBig As Integer = 0
    Private Sub UpdateElevation()
        ' 根據仰角計算抬升高度
        elevation = angle
    End Sub



    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        ' 在PictureBox2上繪製箭頭
        Dim g As Graphics = e.Graphics
        Dim centerX As Integer = PictureBox2.Width \ 2
        Dim centerY As Integer = PictureBox2.Height \ 2

        ' 計算箭頭的位置和方向
        Dim x As Integer = CInt(centerX + elevation * Math.Cos(angle * Math.PI / 180))
        Dim y As Integer = CInt(centerY - elevation * Math.Sin(angle * Math.PI / 180))
        Dim direction As New Point(CInt(10 * Math.Cos(angle * Math.PI / 180)), CInt(-10 * Math.Sin(angle * Math.PI / 180)))

        ' 繪製箭頭
        g.DrawLine(Pens.Blue, x, y, x + direction.X, y + direction.Y)
        g.FillPolygon(Brushes.Blue, {New Point(x + direction.X, y + direction.Y), New Point(x + 5, y + 5), New Point(x - 5, y + 5)})
    End Sub

    Public x As Double = 277.0
    Public y As Double = 562.0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' 定期更新武器的位置g
        If ControlTurn Mod 2 = 0 Then
            weapon_Attack(timeStep, angle, needint, wind)
            PlayerWeapon.Location = New Point(x, y)
            If IsWeaponCollidingWithEnemy() Then
                AxWindowsMediaPlayer3.Ctlcontrols.play() '爆炸音效'
                Timer2.Stop()
                'MsgBox("end")
                EnemyBlood.Width = enemyProgressBar.Width * (EnemyHP - MyAttack) / 100
                EnemyHP = (EnemyHP - MyAttack)
                x = 277
                y = 562
                isUpingNow = True
                isInLowest = False
                PlayerWeapon.Location = New Point(x, y)
                x = 1079
                y = 562
                angle = 30
                count = 0
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        Enemy.Image = My.Resources.受傷_左
                        PlayerWeapon.Image = My.Resources.電腦
                    Case 1
                        Enemy.Image = My.Resources.反向董合昇_被打
                        PlayerWeapon.Image = My.Resources.鱷魚頭_反
                End Select
            ElseIf IsWeaponCollidingWithEnemy() = False AndAlso isInLowest Then
                Timer2.Stop()
                'MsgBox("沒打到")
                x = 277
                y = 562
                PlayerWeapon.Location = New Point(x, y)
                x = 1079
                y = 562
                isUpingNow = True
                isInLowest = False
                angle = 30
                count = 0
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        PlayerWeapon.Image = My.Resources.電腦
                    Case 1
                        PlayerWeapon.Image = My.Resources.鱷魚頭_反
                End Select
            End If
        Else
            weapon_Attack(timeStep, randomAngle, randomNeedint, 0)
            EnemyWeapon.Location = New Point(x, y)
            If IsWeaponCollidingWithEnemy() Then
                AxWindowsMediaPlayer3.Ctlcontrols.play() '爆炸音效'
                Timer2.Stop()
                'MsgBox("end")
                PlayerBlood.Width = playerProgressBar.Width * (MyHP - MyAttack) / 100
                MyHP = MyHP - MyAttack
                x = 1079
                y = 562
                isUpingNow = True
                isInLowest = False
                EnemyWeapon.Location = New Point(x, y)
                x = 277
                y = 562
                randomAngle = 30
                count = 0
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        Player.Image = My.Resources.董合昇_被打
                        EnemyWeapon.Image = My.Resources.鱷魚頭
                    Case 1
                        Player.Image = My.Resources.受傷_右
                        EnemyWeapon.Image = My.Resources.反向電腦
                End Select
            ElseIf IsWeaponCollidingWithEnemy() = False AndAlso isInLowest Then
                Timer2.Stop()
                'MsgBox("沒打到")
                x = 1079
                y = 562
                EnemyWeapon.Location = New Point(x, y)
                x = 277
                y = 562
                isUpingNow = True
                isInLowest = False
                randomAngle = 30
                count = 0
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        EnemyWeapon.Image = My.Resources.鱷魚頭
                    Case 1
                        EnemyWeapon.Image = My.Resources.反向電腦
                End Select
            End If
        End If
        If ControlTurn Mod 2 <> 0 Then
            WhosTurn.Text = "Your Turn"
        Else
            WhosTurn.Text = "Enemy Turn"
        End If

        If MyHP <= 0 Or EnemyHP <= 0 Then
            If MyHP <= 0 Then
                Dim result As MsgBoxResult

                result = MsgBox("您已失敗，是否要繼續遊戲?", MsgBoxStyle.YesNo, "遊戲提示")

                If result = MsgBoxResult.Yes Then
                    TabControl1.SelectedTab = TabControl1.TabPages(1)
                Else
                    TabControl1.SelectedTab = TabControl1.TabPages(0)
                End If
            Else
                Dim result As MsgBoxResult

                result = MsgBox("您已勝利，是否要繼續遊戲?", MsgBoxStyle.YesNo, "遊戲提示")

                If result = MsgBoxResult.Yes Then
                    TabControl1.SelectedTab = TabControl1.TabPages(1)
                Else
                    TabControl1.SelectedTab = TabControl1.TabPages(0)
                End If
            End If
            isEasy = True ' 查詢是否為簡單模式 若是 則無風力
            isUpingNow = True '判斷物體否處於上升階段
            count = 0 '紀錄拋物線運動第幾次
            isInLowest = False '判斷是否在結束拋物線運動的最低點

            IfiCandownSpace = True

            MyAttack = 20 '計算玩家的攻擊數值
            MyHP = 100 '計算玩家的生命值
            EnemyHP = 100 '計算敵人生命值

            TurnTime = 15 '限制玩家15秒內要發動攻擊
            ControlTurn = 1 '奇數表玩家 偶數敵人

            randomNeedint = GetRandomNeedint()
            randomAngle = GetRandomAngle()

            wind = GetRandomWind()

            ifCanKeySkill = True
            BigSkill = 1

            PlayerBlood.Width = playerProgressBar.Width
            EnemyBlood.Width = enemyProgressBar.Width

            Finalskill.Enabled = True

            x = 277
            y = 562

            Select Case ComboBox1.SelectedIndex
                Case 0
                    Player.Image = My.Resources.董合昇_臥倒_拿電腦
                    PlayerWeapon.Image = My.Resources.反向電腦
                    Enemy.Image = My.Resources.拿鱷魚_右
                    EnemyWeapon.Image = My.Resources.鱷魚頭
                    ' Enemy.SizeMode = PictureBoxSizeMode.StretchImage

                    selection = 0
                Case 1
                    Player.Image = My.Resources.拿鱷魚_左
                    PlayerWeapon.Image = My.Resources.鱷魚頭_反
                    Enemy.Image = My.Resources.反向董合昇_臥倒_拿電腦
                    EnemyWeapon.Image = My.Resources.電腦

                    selection = 1
            End Select
        End If
    End Sub

    Public Sub weapon_Attack(timeStep As Double, initialAngle As Double, Needint As Integer, wind As Integer)
        ' 模擬武器運動
        angle = initialAngle * Math.PI / 180 ' 將角度轉換為弧度
        Dim Vx As Double = 0 ' X向初速度
        Dim Vy As Double = 0 ' Y向初速度
        theVelocity_YOfStart = Needint ' 紀錄最一開始的Y方向初速度
        If isEasy Then
            If count = 0 AndAlso isUpingNow Then
                Vx = Needint
                Vy = Needint
            ElseIf count <> 0 AndAlso isUpingNow Then
                Vx = Needint
                Vy = Needint - (count - 0) * (10 * timeStep)
            Else
                Vx = Needint
                Vy = (count - 0) * (10 * timeStep)
                If Vy = theVelocity_YOfStart Then
                    isInLowest = True
                End If
            End If
        Else
            If count = 0 AndAlso isUpingNow Then
                Vx = Needint - wind
                Vy = Needint - wind
            ElseIf count <> 0 AndAlso isUpingNow Then
                Vx = Needint - wind
                Vy = (Needint - wind) - (count - 0) * (10 * timeStep)
            Else
                Vx = Needint - wind
                Vy = (count - 0) * (10 * timeStep)
                If Vy = theVelocity_YOfStart Then
                    isInLowest = True
                End If
            End If

        End If
        count += 1
        If Vy > 0 AndAlso isUpingNow Then
            If ControlTurn Mod 2 = 0 Then
                x += Vx * Math.Cos(angle) * timeStep + 5
                'BigSkill += 1
            Else
                x -= Vx * Math.Cos(angle) * timeStep + 5
            End If
            y -= 30 * Math.Abs(Vy * Math.Sin(angle) * timeStep - (0.5 * 10 * timeStep * timeStep)) ' 將y取反以符合座標系
            If Vy - (10 * timeStep) <= 0 Then
                isUpingNow = False
                count = 0
            End If
        Else
            If ControlTurn Mod 2 = 0 Then
                x += Vx * Math.Cos(angle) * timeStep + 5
            Else
                x -= Vx * Math.Cos(angle) * timeStep + 5
            End If
            y += 30 * Math.Abs(Vy * Math.Sin(angle) * timeStep + (0.5 * 10 * timeStep * timeStep)) ' 將y取反以符合座標系
        End If
    End Sub

    Private Function IsWeaponCollidingWithEnemy() As Boolean
        ' 獲取武器 PictureBox3 和敵人 PictureBox4 的矩形範圍

        Dim weaponRect As New Rectangle(PlayerWeapon.Location, PlayerWeapon.Size)
        Dim enemyRect As New Rectangle(EnemyWeapon.Location, EnemyWeapon.Size)
        Dim enemyC As New Rectangle(Enemy.Location, Enemy.Size)
        Dim playerC As New Rectangle(Player.Location, Player.Size)
        Select Case ControlTurn Mod 2
            Case 0
                Return weaponRect.IntersectsWith(enemyC)
                'TextBox5.Text = "我的"
            Case 1
                Return enemyRect.IntersectsWith(playerC)
                'TextBox5.Text = "你的"
        End Select
        ' 判斷兩個矩形是否相交，如果相交則表示碰撞
        'Return weaponRect.IntersectsWith(enemyRect)
    End Function

    Private Sub 技能1_Click(sender As Object, e As EventArgs) Handles skill1.Click
        Select Case ComboBox1.SelectedIndex
            Case 0
                Player.Image = My.Resources.董合昇_臥倒_空手
                PlayerWeapon.Image = My.Resources.飛毛腿
            Case 1
                Player.Image = My.Resources.拿約克夏_右
        End Select
        TrackBar1.Focus()
        ifCanKeySkill = False
        If Not ifCanKeySkill Then
            skill1.Enabled = False
            skill2.Enabled = False
            Finalskill.Enabled = False
        End If
        If selection = 0 Then
            MyAttack = 20 * 1.5
            使用技能.Text = "使用技能:" & "飛毛腿"
        Else
            MyHP += MyHP * 0.2
            PlayerBlood.Width = playerProgressBar.Width * (MyHP / 100)
            使用技能.Text = "使用技能:" & "約克夏"
        End If
        'TextBox4.Text = MyAttack.ToString()
    End Sub

    Private Sub 技能2_Click(sender As Object, e As EventArgs) Handles skill2.Click
        Select Case ComboBox1.SelectedIndex
            Case 0
                Player.Image = My.Resources.董合昇_拿管理報表
                PlayerWeapon.Image = My.Resources.管理報表
            Case 1
                Player.Image = My.Resources.拿電鋸_左
                PlayerWeapon.Image = My.Resources.電鋸
        End Select
        TrackBar1.Focus()
        ifCanKeySkill = False
        If Not ifCanKeySkill Then
            skill1.Enabled = False
            skill2.Enabled = False
            Finalskill.Enabled = False
        End If
        If selection = 0 Then
            MyAttack = 20 * 1.7
            使用技能.Text = "使用技能:" & "管理報表"
        Else
            MyAttack = 20 * 1.5
            使用技能.Text = "使用技能:" & "鱷魚頭"
        End If
        'TextBox4.Text = MyAttack.ToString()
    End Sub

    Private Sub 大絕招_Click(sender As Object, e As EventArgs) Handles Finalskill.Click
        TrackBar1.Focus()
        BigSkill = 0
        Finalskill.Enabled = False
        使用技能.Text = "使用技能:" & "大招"
        If selection = 0 Then
            '管理報表掉落
        Else
            MyAttack = 20 * 4
        End If
        playerBigDrop.Start()
        'TextBox4.Text = MyAttack.ToString()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        TurnTime -= 1
        回合計時器.Text = TurnTime.ToString()
        If TurnTime <= 0 Then
            回合計時器.Text = "回合結束"
            ControlTurn += 1
            WhosTurn.Text = "Enemy Turn"
            'IfiCandownSpace = False
        End If
    End Sub

    Private Function GetRandomNeedint() As Integer
        ' 使用 Random 類別來產生隨機數字
        Dim random As New Random()

        ' 產生介於 0 到 100 之間的隨機數字
        Dim randomNumber As Integer = random.Next(10, 65)

        Return randomNumber
    End Function
    Private Function GetRandomAngle() As Integer
        ' 使用 Random 類別來產生隨機數字
        Dim random As New Random()

        ' 產生介於 0 到 100 之間的隨機數字
        Dim randomNumber As Integer = random.Next(20, 28)

        Return randomNumber
    End Function

    Private Function GetRandomWind() As Integer
        ' 使用 Random 類別來產生隨機數字
        Dim random As New Random()

        ' 產生介於 0 到 100 之間的隨機數字
        Dim randomNumber As Integer = random.Next(20, 30)

        Return randomNumber
    End Function

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.SelectedIndex <> 0 Then
            WindWarning.Text = "當前風向:" & wind.ToString()
        Else
            WindWarning.Text = "此模式無風無雨"
            wind = 0
        End If
        Select Case ComboBox1.SelectedIndex
            Case 0
                isEasy = True
                'WindWarning.Text = "0"
                Button2.Enabled = True
            Case 1
                isEasy = False
                Button2.Enabled = True
            Case 2
                isEasy = False
                Button2.Enabled = True
            Case -1
                Button2.Enabled = False
        End Select
    End Sub
    Private Sub Music_Click(sender As Object, e As EventArgs) Handles Music.Click
        If Music.Tag = "ON" Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            Music.BackgroundImage = My.Resources.OFF
            Music.Tag = "OFF"
        ElseIf Music.Tag = "OFF" Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Music.BackgroundImage = My.Resources._ON
            Music.Tag = "ON"
        End If
    End Sub

    Private Sub playerBigDrop_Tick(sender As Object, e As EventArgs) Handles playerBigDrop.Tick
        playerBig.Visible = True
        LocationY_playerBig += 20
        playerBig.Location = New Point(1079, LocationY_playerBig)
        If LocationY_playerBig >= Enemy.Top Then
            EnemyBlood.Width = enemyProgressBar.Width * (EnemyHP - 50) / 100
            EnemyHP -= 50
            LocationY_playerBig = 0
            playerBig.Visible = False
            playerBigDrop.Stop()
        End If
        If MyHP <= 0 Or EnemyHP <= 0 Then
            If MyHP <= 0 Then
                Dim result As MsgBoxResult

                result = MsgBox("您已失敗，是否要繼續遊戲?", MsgBoxStyle.YesNo, "遊戲提示")

                If result = MsgBoxResult.Yes Then
                    TabControl1.SelectedTab = TabControl1.TabPages(1)
                Else
                    TabControl1.SelectedTab = TabControl1.TabPages(0)
                End If
            Else
                Dim result As MsgBoxResult

                result = MsgBox("您已勝利，是否要繼續遊戲?", MsgBoxStyle.YesNo, "遊戲提示")

                If result = MsgBoxResult.Yes Then
                    TabControl1.SelectedTab = TabControl1.TabPages(1)
                Else
                    TabControl1.SelectedTab = TabControl1.TabPages(0)
                End If
            End If
            isEasy = True ' 查詢是否為簡單模式 若是 則無風力
            isUpingNow = True '判斷物體否處於上升階段
            count = 0 '紀錄拋物線運動第幾次
            isInLowest = False '判斷是否在結束拋物線運動的最低點

            IfiCandownSpace = True

            MyAttack = 20 '計算玩家的攻擊數值
            MyHP = 100 '計算玩家的生命值
            EnemyHP = 100 '計算敵人生命值

            TurnTime = 15 '限制玩家15秒內要發動攻擊
            ControlTurn = 1 '奇數表玩家 偶數敵人

            randomNeedint = GetRandomNeedint()
            randomAngle = GetRandomAngle()

            wind = GetRandomWind()

            ifCanKeySkill = True
            BigSkill = 1

            PlayerBlood.Width = playerProgressBar.Width
            EnemyBlood.Width = enemyProgressBar.Width

            Finalskill.Enabled = True

            x = 277
            y = 562

            Select Case ComboBox1.SelectedIndex
                Case 0
                    Player.Image = My.Resources.董合昇_臥倒_拿電腦
                    PlayerWeapon.Image = My.Resources.反向電腦
                    Enemy.Image = My.Resources.拿鱷魚_右
                    EnemyWeapon.Image = My.Resources.鱷魚頭
                    ' Enemy.SizeMode = PictureBoxSizeMode.StretchImage

                    selection = 0
                Case 1
                    Player.Image = My.Resources.拿鱷魚_左
                    PlayerWeapon.Image = My.Resources.鱷魚頭_反
                    Enemy.Image = My.Resources.反向董合昇_臥倒_拿電腦
                    EnemyWeapon.Image = My.Resources.電腦

                    selection = 1
            End Select
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub

    Private Sub StoryBook_Click(sender As Object, e As EventArgs) Handles StoryBook.Click
        MsgBox("    有兩位傑出的資訊管理系教授，分別是電商小王子和鱷魚殺手。電商小王子以其在籽蟳鸛梨系統領域的卓越知識聞名，他擅長將複雜的資訊科技概念生動易懂地傳授給學生，他的課程深受學生喜愛。

    然而，電商小王子常常忍不住在課堂上開了一個關於鱷魚殺手的玩笑，這個玩笑透過學生的口耳相傳，輾轉傳到了鱷魚殺手的耳中。鱷魚殺手，以其在資訊安全和網路攻防方面的卓越能力而聞名，對於被拿來當笑柄感到極為不高興。

    作為回應，鱷魚殺手決定利用Internet，進行封包交換，將一封挑戰信切斷並重新組合，然後送到電商小王子的電腦上。挑戰信中，鱷魚殺手提出了一場資訊上的知識對決，他要求電商小王子接受挑戰，希望在對決中證明自己的實力，同時也期望讓電商小王子住嘴，以及決定誰才是資管系的真正king。",, "故事介紹")
    End Sub

    Private Sub GameIntro_Click(sender As Object, e As EventArgs) Handles GameIntro.Click
        MsgBox("點擊「開始遊戲」後，進入選角畫面，可自由調整難易度及選擇角色。難易度分為「簡單」、「普通」、「困難」，簡單模式下無風向干擾，普通模式有風向干擾，困難模式則除了風向干擾外，敵人傷害也會提升。每個角色都擁有獨特的專屬技能。

選擇完畢後，點選右下方按鈕，正式進入遊戲。進入遊戲後，玩家可使用上下鍵調整射擊角度，空格鍵進行蓄力，按下 Enter 發射。輪到敵人的回合時，按下 Enter 讓敵人開始攻擊。",, "遊戲玩法與介紹")
    End Sub

    Private Sub Music2_Click(sender As Object, e As EventArgs) Handles Music2.Click
        If Music2.Tag = "ON" Then
            AxWindowsMediaPlayer2.Ctlcontrols.pause()
            Music2.BackgroundImage = My.Resources.OFF
            Music2.Tag = "OFF"
        ElseIf Music2.Tag = "OFF" Then
            AxWindowsMediaPlayer2.Ctlcontrols.play()
            Music2.BackgroundImage = My.Resources._ON
            Music2.Tag = "ON"
        End If
    End Sub

End Class



