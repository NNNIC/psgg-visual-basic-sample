Public Class TestControl

    ' Manager
    Private m_curstate As String
    Private m_nextstate As String
    Private m_nowait As Boolean

    Public Sub New()
        m_curstate = ""
        m_nextstate = ""
    End Sub

    Public Sub Update()
        Dim bFirst As Boolean

        LoopUpdate:
        
        bFirst = False

        If m_nextstate <> "" Then 
            m_curstate = m_nextstate
            m_nextstate = ""
            bFirst = True
        End If

        m_nowait = False

        '[SYN-G-GEN OUTPUT START] indent(8) $/^S_/->#select$
'  psggConverterLib.dll converted from TestControl.xlsx. 
        If m_curstate = "S_0001" Then
            S_0001(bFirst)
            Goto ExitUpdate
        End If
        If m_curstate = "S_0002" Then
            S_0002(bFirst)
            Goto ExitUpdate
        End If
        If m_curstate = "S_0003" Then
            S_0003(bFirst)
            Goto ExitUpdate
        End If
        If m_curstate = "S_0004" Then
            S_0004(bFirst)
            Goto ExitUpdate
        End If
        If m_curstate = "S_END" Then
            S_END(bFirst)
            Goto ExitUpdate
        End If
        If m_curstate = "S_START" Then
            S_START(bFirst)
            Goto ExitUpdate
        End If


        '[SYN-G-GEN OUTPUT END]

        ExitUpdate:

        If m_nowait = True Then
            Goto LoopUpdate
        End If

    End Sub

    private Sub GotoState( state As String )
        m_nextstate = state
    End Sub

    private Function CheckState( state As String ) As Boolean
        If state = m_curstate Then
            Return True
        Else
            Return False
        End If
    End Function

    private Function HasNextState()
        If m_nextstate <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    private Sub SetNoWait()
        m_nowait = True
    End Sub

    public Sub Start()
        GotoState("S_START")
    End Sub

    public Function IsEnd() As Boolean
        If m_curstate = "S_END" Then
            Return True
        Else
            Return False
        End If
    End Function

    '[SYN-G-GEN OUTPUT START] indent(8) $/./$
'  psggConverterLib.dll converted from TestControl.xlsx. 
        '    S_0001
        '    new state
        Sub S_0001(bFirst As Boolean)
            Dim i As Integer
            if bFirst = True Then
                i = 2
            End If
        ' branch
        If i = 1 Then
            m_nextstate = "S_0002"
        ElseIf i = 2 Then
            m_nextstate = "S_0004"
            Else
                m_nextstate = "S_0003"
            End If
        End Sub
        '    S_0002
        '    new state
        Sub S_0002(bFirst As Boolean)
            if bFirst = True Then
                MsgBox("1", _
                    MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, _
                    "Answer")
            End If
            If HasNextState() = False Then
                GotoState("S_END")
            End If
        End Sub
        '    S_0003
        '    new state
        Sub S_0003(bFirst As Boolean)
            if bFirst = True Then
                MsgBox("?", _
                    MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, _
                    "Answer")
            End If
            If HasNextState() = False Then
                GotoState("S_END")
            End If
        End Sub
        '    S_0004
        '    new state
        Sub S_0004(bFirst As Boolean)
            if bFirst = True Then
                MsgBox("2", _
                    MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, _
                    "Answer")
            End If
            If HasNextState() = False Then
                GotoState("S_END")
            End If
        End Sub
        '    S_END
        '
        Sub S_END(bFirst As Boolean)
        End Sub
        '    S_START
        '
        Sub S_START(bFirst As Boolean)
            If HasNextState() = False Then
                GotoState("S_0001")
            End If
        End Sub


    '[SYN-G-GEN OUTPUT END]

End Class