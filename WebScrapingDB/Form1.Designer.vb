<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(376, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "取得開始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "地域："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(293, 19)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(77, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(293, 19)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "キーワード："
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(540, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 42)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "閉じる"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(14, 111)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(347, 235)
        Me.TextBox3.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "WebRequest抽出結果："
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(411, 112)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox4.Size = New System.Drawing.Size(289, 234)
        Me.TextBox4.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(367, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "⇒"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(414, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "抽出結果："
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 364)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 42)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "一覧表示(SELECT)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 12)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "WebRequest送信先："
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(180, 364)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(158, 42)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "削除(DELETE)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(344, 364)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(158, 42)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "更新(UPDATE)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(16, 412)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(682, 208)
        Me.ListBox1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 637)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "WebスクレイピングとMySQL(追加・参照・削除・更新)のサンプルプログラム"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
