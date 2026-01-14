<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Music = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.StoryBook = New System.Windows.Forms.PictureBox()
        Me.MISTeacher = New System.Windows.Forms.PictureBox()
        Me.HeadLine = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GameIntro = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.detect = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Music2 = New System.Windows.Forms.PictureBox()
        Me.WhosTurn = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.EnergyPanel = New System.Windows.Forms.Panel()
        Me.EnergyBar = New System.Windows.Forms.ProgressBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.WindWarning = New System.Windows.Forms.Label()
        Me.回合計時器 = New System.Windows.Forms.Label()
        Me.使用技能 = New System.Windows.Forms.Label()
        Me.PlayerBlood = New System.Windows.Forms.Panel()
        Me.EnemyBlood = New System.Windows.Forms.Panel()
        Me.playerProgressBar = New System.Windows.Forms.ProgressBar()
        Me.enemyProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Finalskill = New System.Windows.Forms.Button()
        Me.skill2 = New System.Windows.Forms.Button()
        Me.skill1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.enemyBig = New System.Windows.Forms.PictureBox()
        Me.playerBig = New System.Windows.Forms.PictureBox()
        Me.Enemy = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.EnemyWeapon = New System.Windows.Forms.PictureBox()
        Me.PlayerWeapon = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.P1BackgroundTimer = New System.Windows.Forms.Timer(Me.components)
        Me.playerBigDrop = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Music, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoryBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MISTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Music2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemyBig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerBig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyWeapon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerWeapon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1259, 572)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Music)
        Me.TabPage1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.TabPage1.Controls.Add(Me.StoryBook)
        Me.TabPage1.Controls.Add(Me.MISTeacher)
        Me.TabPage1.Controls.Add(Me.HeadLine)
        Me.TabPage1.Controls.Add(Me.ExitButton)
        Me.TabPage1.Controls.Add(Me.GameIntro)
        Me.TabPage1.Controls.Add(Me.StartButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1251, 543)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Music
        '
        Me.Music.Location = New System.Drawing.Point(669, 238)
        Me.Music.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Music.Name = "Music"
        Me.Music.Size = New System.Drawing.Size(100, 50)
        Me.Music.TabIndex = 6
        Me.Music.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(233, 142)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 5
        '
        'StoryBook
        '
        Me.StoryBook.Location = New System.Drawing.Point(923, 30)
        Me.StoryBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StoryBook.Name = "StoryBook"
        Me.StoryBook.Size = New System.Drawing.Size(100, 50)
        Me.StoryBook.TabIndex = 4
        Me.StoryBook.TabStop = False
        '
        'MISTeacher
        '
        Me.MISTeacher.Location = New System.Drawing.Point(636, 92)
        Me.MISTeacher.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MISTeacher.Name = "MISTeacher"
        Me.MISTeacher.Size = New System.Drawing.Size(100, 50)
        Me.MISTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MISTeacher.TabIndex = 3
        Me.MISTeacher.TabStop = False
        '
        'HeadLine
        '
        Me.HeadLine.Location = New System.Drawing.Point(427, 92)
        Me.HeadLine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(100, 50)
        Me.HeadLine.TabIndex = 1
        Me.HeadLine.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(452, 345)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 22)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GameIntro
        '
        Me.GameIntro.Location = New System.Drawing.Point(452, 290)
        Me.GameIntro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GameIntro.Name = "GameIntro"
        Me.GameIntro.Size = New System.Drawing.Size(75, 22)
        Me.GameIntro.TabIndex = 1
        Me.GameIntro.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(452, 234)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 22)
        Me.StartButton.TabIndex = 0
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.detect)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.PictureBox5)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(1251, 543)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'detect
        '
        Me.detect.AutoSize = True
        Me.detect.Location = New System.Drawing.Point(105, 411)
        Me.detect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.detect.Name = "detect"
        Me.detect.Size = New System.Drawing.Size(0, 15)
        Me.detect.TabIndex = 12
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"簡單", "普通", "困難"})
        Me.ComboBox2.Location = New System.Drawing.Point(95, 272)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(167, 33)
        Me.ComboBox2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(89, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 34)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "請選擇模式"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(89, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 34)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "請選擇角色"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"電商小王子", "鱷魚殺手"})
        Me.ComboBox1.Location = New System.Drawing.Point(92, 148)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 33)
        Me.ComboBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(573, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "角色介紹"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("新細明體", 13.0!)
        Me.Button3.Location = New System.Drawing.Point(579, 342)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 42)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "返回上一頁"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("新細明體", 13.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Coral
        Me.Button2.Location = New System.Drawing.Point(579, 280)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 45)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "進入遊戲"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(771, 38)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(480, 500)
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(235, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(709, 680)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Music2)
        Me.TabPage3.Controls.Add(Me.WhosTurn)
        Me.TabPage3.Controls.Add(Me.AxWindowsMediaPlayer4)
        Me.TabPage3.Controls.Add(Me.AxWindowsMediaPlayer3)
        Me.TabPage3.Controls.Add(Me.EnergyPanel)
        Me.TabPage3.Controls.Add(Me.EnergyBar)
        Me.TabPage3.Controls.Add(Me.TrackBar1)
        Me.TabPage3.Controls.Add(Me.WindWarning)
        Me.TabPage3.Controls.Add(Me.回合計時器)
        Me.TabPage3.Controls.Add(Me.使用技能)
        Me.TabPage3.Controls.Add(Me.PlayerBlood)
        Me.TabPage3.Controls.Add(Me.EnemyBlood)
        Me.TabPage3.Controls.Add(Me.playerProgressBar)
        Me.TabPage3.Controls.Add(Me.enemyProgressBar)
        Me.TabPage3.Controls.Add(Me.Finalskill)
        Me.TabPage3.Controls.Add(Me.skill2)
        Me.TabPage3.Controls.Add(Me.skill1)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.TabPage3.Controls.Add(Me.enemyBig)
        Me.TabPage3.Controls.Add(Me.playerBig)
        Me.TabPage3.Controls.Add(Me.Enemy)
        Me.TabPage3.Controls.Add(Me.Player)
        Me.TabPage3.Controls.Add(Me.EnemyWeapon)
        Me.TabPage3.Controls.Add(Me.PlayerWeapon)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Size = New System.Drawing.Size(1251, 543)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Music2
        '
        Me.Music2.Location = New System.Drawing.Point(1065, 34)
        Me.Music2.Name = "Music2"
        Me.Music2.Size = New System.Drawing.Size(132, 96)
        Me.Music2.TabIndex = 30
        Me.Music2.TabStop = False
        '
        'WhosTurn
        '
        Me.WhosTurn.AutoSize = True
        Me.WhosTurn.Font = New System.Drawing.Font("新細明體", 24.0!)
        Me.WhosTurn.Location = New System.Drawing.Point(680, 34)
        Me.WhosTurn.Name = "WhosTurn"
        Me.WhosTurn.Size = New System.Drawing.Size(122, 40)
        Me.WhosTurn.TabIndex = 29
        Me.WhosTurn.Text = "Label4"
        '
        'AxWindowsMediaPlayer4
        '
        Me.AxWindowsMediaPlayer4.Enabled = True
        Me.AxWindowsMediaPlayer4.Location = New System.Drawing.Point(1122, 286)
        Me.AxWindowsMediaPlayer4.Name = "AxWindowsMediaPlayer4"
        Me.AxWindowsMediaPlayer4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer4.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer4.TabIndex = 28
        '
        'AxWindowsMediaPlayer3
        '
        Me.AxWindowsMediaPlayer3.Enabled = True
        Me.AxWindowsMediaPlayer3.Location = New System.Drawing.Point(875, 286)
        Me.AxWindowsMediaPlayer3.Name = "AxWindowsMediaPlayer3"
        Me.AxWindowsMediaPlayer3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer3.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer3.TabIndex = 27
        '
        'EnergyPanel
        '
        Me.EnergyPanel.Location = New System.Drawing.Point(44, 380)
        Me.EnergyPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EnergyPanel.Name = "EnergyPanel"
        Me.EnergyPanel.Size = New System.Drawing.Size(11, 14)
        Me.EnergyPanel.TabIndex = 1
        '
        'EnergyBar
        '
        Me.EnergyBar.Location = New System.Drawing.Point(44, 380)
        Me.EnergyBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EnergyBar.Name = "EnergyBar"
        Me.EnergyBar.Size = New System.Drawing.Size(149, 15)
        Me.EnergyBar.TabIndex = 0
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(89, 304)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(700, 56)
        Me.TrackBar1.TabIndex = 3
        '
        'WindWarning
        '
        Me.WindWarning.AutoSize = True
        Me.WindWarning.Font = New System.Drawing.Font("新細明體", 16.0!)
        Me.WindWarning.Location = New System.Drawing.Point(503, 260)
        Me.WindWarning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WindWarning.Name = "WindWarning"
        Me.WindWarning.Size = New System.Drawing.Size(120, 27)
        Me.WindWarning.TabIndex = 20
        Me.WindWarning.Text = "當前風向"
        '
        '回合計時器
        '
        Me.回合計時器.AutoSize = True
        Me.回合計時器.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.回合計時器.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.回合計時器.Location = New System.Drawing.Point(1004, 286)
        Me.回合計時器.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.回合計時器.Name = "回合計時器"
        Me.回合計時器.Size = New System.Drawing.Size(47, 34)
        Me.回合計時器.TabIndex = 18
        Me.回合計時器.Text = "15"
        '
        '使用技能
        '
        Me.使用技能.AutoSize = True
        Me.使用技能.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.使用技能.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.使用技能.Location = New System.Drawing.Point(883, 392)
        Me.使用技能.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.使用技能.Name = "使用技能"
        Me.使用技能.Size = New System.Drawing.Size(141, 30)
        Me.使用技能.TabIndex = 17
        Me.使用技能.Text = "使用技能:"
        '
        'PlayerBlood
        '
        Me.PlayerBlood.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PlayerBlood.Location = New System.Drawing.Point(343, 34)
        Me.PlayerBlood.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerBlood.Name = "PlayerBlood"
        Me.PlayerBlood.Size = New System.Drawing.Size(133, 29)
        Me.PlayerBlood.TabIndex = 16
        '
        'EnemyBlood
        '
        Me.EnemyBlood.Location = New System.Drawing.Point(875, 34)
        Me.EnemyBlood.Margin = New System.Windows.Forms.Padding(4)
        Me.EnemyBlood.Name = "EnemyBlood"
        Me.EnemyBlood.Size = New System.Drawing.Size(133, 29)
        Me.EnemyBlood.TabIndex = 15
        '
        'playerProgressBar
        '
        Me.playerProgressBar.Location = New System.Drawing.Point(343, 34)
        Me.playerProgressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.playerProgressBar.Name = "playerProgressBar"
        Me.playerProgressBar.Size = New System.Drawing.Size(133, 29)
        Me.playerProgressBar.TabIndex = 14
        '
        'enemyProgressBar
        '
        Me.enemyProgressBar.Location = New System.Drawing.Point(875, 34)
        Me.enemyProgressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.enemyProgressBar.Name = "enemyProgressBar"
        Me.enemyProgressBar.Size = New System.Drawing.Size(133, 29)
        Me.enemyProgressBar.TabIndex = 13
        '
        'Finalskill
        '
        Me.Finalskill.Location = New System.Drawing.Point(908, 430)
        Me.Finalskill.Margin = New System.Windows.Forms.Padding(4)
        Me.Finalskill.Name = "Finalskill"
        Me.Finalskill.Size = New System.Drawing.Size(100, 29)
        Me.Finalskill.TabIndex = 12
        Me.Finalskill.Text = "大絕招"
        Me.Finalskill.UseVisualStyleBackColor = True
        '
        'skill2
        '
        Me.skill2.Location = New System.Drawing.Point(972, 342)
        Me.skill2.Margin = New System.Windows.Forms.Padding(4)
        Me.skill2.Name = "skill2"
        Me.skill2.Size = New System.Drawing.Size(100, 60)
        Me.skill2.TabIndex = 11
        Me.skill2.UseVisualStyleBackColor = True
        '
        'skill1
        '
        Me.skill1.Location = New System.Drawing.Point(924, 211)
        Me.skill1.Margin = New System.Windows.Forms.Padding(4)
        Me.skill1.Name = "skill1"
        Me.skill1.Size = New System.Drawing.Size(100, 60)
        Me.skill1.TabIndex = 10
        Me.skill1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.Thistle
        Me.TextBox2.Location = New System.Drawing.Point(555, 98)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(43, 35)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.TextBox1.Location = New System.Drawing.Point(227, 380)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(45, 35)
        Me.TextBox1.TabIndex = 2
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(401, 158)
        Me.AxWindowsMediaPlayer2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer2.TabIndex = 24
        '
        'enemyBig
        '
        Me.enemyBig.Location = New System.Drawing.Point(908, 72)
        Me.enemyBig.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.enemyBig.Name = "enemyBig"
        Me.enemyBig.Size = New System.Drawing.Size(65, 75)
        Me.enemyBig.TabIndex = 26
        Me.enemyBig.TabStop = False
        '
        'playerBig
        '
        Me.playerBig.Location = New System.Drawing.Point(401, 72)
        Me.playerBig.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.playerBig.Name = "playerBig"
        Me.playerBig.Size = New System.Drawing.Size(269, 168)
        Me.playerBig.TabIndex = 25
        Me.playerBig.TabStop = False
        '
        'Enemy
        '
        Me.Enemy.Image = Global.pagetest.My.Resources.Resources.反向董合昇_臥倒_拿電腦
        Me.Enemy.Location = New System.Drawing.Point(144, 34)
        Me.Enemy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Enemy.Name = "Enemy"
        Me.Enemy.Size = New System.Drawing.Size(100, 50)
        Me.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Enemy.TabIndex = 22
        Me.Enemy.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.pagetest.My.Resources.Resources.董合昇_臥倒_拿電腦
        Me.Player.Location = New System.Drawing.Point(0, 0)
        Me.Player.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(100, 50)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player.TabIndex = 21
        Me.Player.TabStop = False
        '
        'EnemyWeapon
        '
        Me.EnemyWeapon.Image = Global.pagetest.My.Resources.Resources.反向電腦
        Me.EnemyWeapon.Location = New System.Drawing.Point(673, 389)
        Me.EnemyWeapon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EnemyWeapon.Name = "EnemyWeapon"
        Me.EnemyWeapon.Size = New System.Drawing.Size(100, 50)
        Me.EnemyWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EnemyWeapon.TabIndex = 9
        Me.EnemyWeapon.TabStop = False
        '
        'PlayerWeapon
        '
        Me.PlayerWeapon.Image = Global.pagetest.My.Resources.Resources.電腦
        Me.PlayerWeapon.Location = New System.Drawing.Point(429, 366)
        Me.PlayerWeapon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PlayerWeapon.Name = "PlayerWeapon"
        Me.PlayerWeapon.Size = New System.Drawing.Size(65, 56)
        Me.PlayerWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlayerWeapon.TabIndex = 5
        Me.PlayerWeapon.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(20, 84)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(295, 194)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 5
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'P1BackgroundTimer
        '
        Me.P1BackgroundTimer.Interval = 1000
        '
        'playerBigDrop
        '
        Me.playerBigDrop.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 572)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Music, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoryBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MISTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Music2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemyBig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerBig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyWeapon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerWeapon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents StartButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents EnergyBar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents EnergyPanel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PlayerWeapon As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents EnemyWeapon As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents GameIntro As Button
    Friend WithEvents StoryBook As PictureBox
    Friend WithEvents MISTeacher As PictureBox
    Friend WithEvents HeadLine As PictureBox
    Friend WithEvents P1BackgroundTimer As Timer
    Friend WithEvents Finalskill As Button
    Friend WithEvents skill2 As Button
    Friend WithEvents skill1 As Button
    Friend WithEvents PlayerBlood As Panel
    Friend WithEvents EnemyBlood As Panel
    Friend WithEvents playerProgressBar As ProgressBar
    Friend WithEvents enemyProgressBar As ProgressBar
    Friend WithEvents 使用技能 As Label
    Friend WithEvents 回合計時器 As Label
    Friend WithEvents WindWarning As Label
    Friend WithEvents detect As Label
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Player As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Music As PictureBox
    Friend WithEvents enemyBig As PictureBox
    Friend WithEvents playerBig As PictureBox
    Friend WithEvents playerBigDrop As Timer
    Friend WithEvents AxWindowsMediaPlayer4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents WhosTurn As Label
    Friend WithEvents Music2 As PictureBox
End Class
