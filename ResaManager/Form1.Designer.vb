<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.request = New System.Windows.Forms.TextBox()
        Me.delnamebox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ResaManager = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_OpenMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "봇 전송"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 108)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(242, 61)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(242, 21)
        Me.TextBox2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(242, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "192.168.0.15 커멘드전송"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'request
        '
        Me.request.Location = New System.Drawing.Point(10, 229)
        Me.request.Name = "request"
        Me.request.Size = New System.Drawing.Size(244, 21)
        Me.request.TabIndex = 4
        '
        'delnamebox
        '
        Me.delnamebox.Location = New System.Drawing.Point(12, 12)
        Me.delnamebox.Name = "delnamebox"
        Me.delnamebox.Size = New System.Drawing.Size(242, 21)
        Me.delnamebox.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 36)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "제거"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 290)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(242, 28)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Load"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(98, 39)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 36)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "대체"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ResaManager
        '
        Me.ResaManager.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ResaManager.Icon = CType(resources.GetObject("ResaManager.Icon"), System.Drawing.Icon)
        Me.ResaManager.Text = "NotifyIcon1"
        Me.ResaManager.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_OpenMain, Me.Menu_Exit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.ShowItemToolTips = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 52)
        '
        'Menu_OpenMain
        '
        Me.Menu_OpenMain.Name = "Menu_OpenMain"
        Me.Menu_OpenMain.Size = New System.Drawing.Size(174, 24)
        Me.Menu_OpenMain.Text = "Resa 메인 창 열기"
        '
        'Menu_Exit
        '
        Me.Menu_Exit.Name = "Menu_Exit"
        Me.Menu_Exit.Size = New System.Drawing.Size(174, 24)
        Me.Menu_Exit.Text = "종료"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(184, 39)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 36)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "추가"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 334)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.delnamebox)
        Me.Controls.Add(Me.request)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "ResaManager"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents request As TextBox
    Friend WithEvents delnamebox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ResaManager As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Menu_OpenMain As ToolStripMenuItem
    Friend WithEvents Menu_Exit As ToolStripMenuItem
    Friend WithEvents Button6 As Button
End Class
