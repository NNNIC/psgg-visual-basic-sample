Module Module1

    Sub Main()
        Dim sm As New TestControl
        sm.Start()
        While sm.IsEnd() = False
            sm.Update()
        End While

    End Sub

End Module
