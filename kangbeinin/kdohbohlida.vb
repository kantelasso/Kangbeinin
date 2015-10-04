Public Class kdohbohlida

    'les variables stoquants les questions du chapitre en cours de test
    'q = question, table = tableau
    Dim qt(2, 10) As String

    Dim q0, q1, q2, q3, q4, q5, q6, q7, q8, q9, r0, r1, r2, r3, r4, r5, r6, r7, r8, r9 As String

    Public Function AlouQuestions()

        ' transfert les questions et les reponses dans une variable tableau 
        ' les transfère par la suite au lebels pour l'affichage

        For a = 0 To 1
            For b = 0 To 9
                tqs(a, b) = qt(a, b)
            Next
        Next

        qNIntro1.Text = tqs(0, 0)
        qNIntro2.Text = tqs(0, 1)
        qNIntro3.Text = tqs(0, 2)
        qNIntro4.Text = tqs(0, 3)
        qNIntro5.Text = tqs(0, 4)
        qNIntro6.Text = tqs(0, 5)
        qNIntro7.Text = tqs(0, 6)
        qNIntro8.Text = tqs(0, 7)
        qNIntro9.Text = tqs(0, 8)
        qNIntro10.Text = tqs(0, 9)

        rNIntro1.Text = tqs(1, 0)
        rNIntro2.Text = tqs(1, 1)
        rNIntro3.Text = tqs(1, 2)
        rNIntro4.Text = tqs(1, 3)
        rNIntro5.Text = tqs(1, 4)
        rNIntro6.Text = tqs(1, 5)
        rNIntro7.Text = tqs(1, 6)
        rNIntro8.Text = tqs(1, 7)
        rNIntro9.Text = tqs(1, 8)
        rNIntro10.Text = tqs(1, 9)

    End Function

    Public Sub chap1()
        '--------les questions et leur reponses pour le premier chapitre --------

        If test0.Text = "test0" Then

            'Les notes des questions du test de l'Introduction du Nom 

            If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߒ ߡߊ߫ ߓߌ߫ ߝߟߐ߫." Then

                'ce cas particulier, aloue la valeur string des lebels au variable question à traiter
                tqs(0, 0) = qNIntro1.Text
                tqs(0, 1) = qNIntro2.Text
                tqs(0, 2) = qNIntro3.Text
                tqs(0, 3) = qNIntro4.Text
                tqs(0, 4) = qNIntro5.Text
                tqs(0, 5) = qNIntro6.Text
                tqs(0, 6) = qNIntro7.Text
                tqs(0, 7) = qNIntro8.Text
                tqs(0, 8) = qNIntro9.Text
                tqs(0, 9) = qNIntro10.Text

                tqs(1, 0) = rNIntro1.Text
                tqs(1, 1) = rNIntro2.Text
                tqs(1, 2) = rNIntro3.Text
                tqs(1, 3) = rNIntro4.Text
                tqs(1, 4) = rNIntro5.Text
                tqs(1, 5) = rNIntro6.Text
                tqs(1, 6) = rNIntro7.Text
                tqs(1, 7) = rNIntro8.Text
                tqs(1, 8) = rNIntro9.Text
                tqs(1, 9) = rNIntro10.Text


                notabVrai(0, 0) = +1
                notabVrai(1, 0) = -1

                notabVrai(0, 1) = -1
                notabVrai(1, 1) = +1

                notabVrai(0, 2) = +1
                notabVrai(2, 2) = -1

                notabVrai(0, 3) = -1
                notabVrai(1, 3) = +1

                notabVrai(0, 4) = -1
                notabVrai(1, 4) = +1

                notabVrai(0, 5) = -1
                notabVrai(1, 5) = +1

                notabVrai(0, 6) = +1
                notabVrai(1, 6) = -1

                notabVrai(0, 7) = -1
                notabVrai(1, 7) = +1

                notabVrai(0, 8) = +1
                notabVrai(1, 8) = -1

                notabVrai(0, 9) = +1
                notabVrai(1, 9) = -1

                'cette partie recopie le contenu du tableau notaVrai() au tableau ntqs()
                For a = 0 To 1
                    For b = 0 To 9
                        ntqs(a, b) = notabVrai(a, b)
                    Next
                Next


            ElseIf pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
                'renverseNotes()

            End If


            'lesquestions du test du nom presonnel
        ElseIf test0.Text = "test1" Then

            If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߒ ߡߊ߫ ߓߌ߫ ߝߟߐ߫." Then


                qt(0, 0) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߦߋ߫ ߟߊ߫ ߟߊ߫ ߝߋ߲߫ ߛߎ߯ ߁ ߛߌߦߊߡߊ߲߫ ߠߋ߬ ߟߊ߫."

                qt(0, 1) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߕߍ߫ ߟߊ߫ ߟߊ߫ ߛߏ ߟߎ߬ ߟߊ߫."

                qt(0, 2) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߦߋ߫ ߟߊ߫ ߟߊ߫ ߓߌߦߊ߲ ߠߎ߬ ߟߊ߫."

                qt(0, 3) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߖߍ߬ߘߍߖߍ߬ߘߍ ߓߍ߯ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߠߊߓߙߊ߬ߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(0, 4) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߘߏ߫ ߟߎ߫ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߡߝߊߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(0, 5) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߰ ߡߝߊߣߍ߲ ߓߊߖߎ ߦߋ߫ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߟߋ߬ ߘߌ߫."

                qt(0, 6) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߟߊߓߊ߲ߣߍ߲߫ ߞߊ߲߫ ߡߝߊߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(0, 7) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߦߋ߫ ߟߊ߫ ߟߊ߫ ߝߋ߲߫ ߘߋ߲߫ ߞߋߟߋ߲߫ ߠߋ߬ ߟߊ߫."

                qt(0, 8) = "ߝߋ߲߫ ߁ ߞߏߝߐ߫ ߕߐ߮ ߟߋ߫ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߘߌ߫."

                qt(0, 9) = "ߣߝߊ߬ ߛߌ߫ ߕߍ߫ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߟߊ߫."


                qt(1, 0) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߦߋ߫ ߟߊ߫ ߟߊ߫ ߝߋ߲߫ ߘߋ߲߫ ߁ ߔߋ߫ ߟߋ߬ ߟߊ߫."

                qt(1, 1) = "ߊ߬ ߦߋ߫ ߟߊ߫ ߟߊ߫ ߝߋ߲߫ ߓߍ߯ ߟߋ߬ ߟߊ߫ ߤߊߟߌ߬ ߛߏ ߟߎ߬ (ߦߏ߫ ߞߌ߬ߢߍ߬ߓߊ߬)."

                qt(1, 2) = "ߞߏߛߓߍ߫߸ ߊ߬ ߘߌ߫ ߟߊ߫ ߓߌߦߊ߲ ߠߎ߬ ߟߊ߫ (ߦߏ߫ ߥߎ߬ߟߎ ߓߊ߯ ߕߐ߯ߟߊ߫ ߞߏ߫ ߛߎ߬ߟߊ߬ߝߊ߰)."

                qt(1, 3) = "ߕߎ߬ߢߊ߬߹ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߖߍ߬ߘߍߖߍ߬ߘߍ ߓߍ߯ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߠߊߓߙߊ߬ߣߍ߲ ߠߋ߫ ߡߊ߬ ߞߊߘߊߎ߫."

                qt(1, 4) = "ߏ߬ ߦߋ߫ ߕߋ߲߬߸ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߢߌ߬ߣߊ߬ߓߐ߬ߕߊ ߟߎ߬ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߡߝߊߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(1, 5) = "ߍ߲߬ߍ߲߫߸ ߏ߬ ߓߊߛߎ߲ ߦߋ߫ ߝߘߏ߬ߓߊ߬ߕߐ߮ ߟߋ߬ ߘߌ߫."

                qt(1, 6) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߠߊߓߙߊ߬ߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(1, 7) = "ߤߐ߲ߞߍ߬߸ ߊ߬ ߦߋ߫ ߟߊ߫ ߟߊ߫ ߝߋ߲߫ ߘߋ߲߫ ߁ ߠߋ߬ ߟߊ߫ ߖߐ߫."

                qt(1, 8) = "ߞߏߛߓߍ߫߸ ߊ߬ ߞߘߐ ߟߋ߫ ߜߎ ߏ߬ ߘߌ߫."

                qt(1, 9) = "ߍ߲߬ߍ߲߫ ߣߝߊ߬ߓߊ ߟߴߊ߬ ߟߊ߫߸ ߞߊ߬ ߝߋ߲߫ ߓߍ߯ ߛߐ߫ ߊ߬ ߘߎ߲߬ߘߎ߲߬ߡߊ߬ ߕߐ߯ ߟߊ߫ ߞߍ߬."


                'Faire correspondre les question au lebel question reponses
                AlouQuestions()

                ' la note des questions choisies
                notabVrai(0, 0) = +1
                notabVrai(1, 0) = -1

                notabVrai(0, 1) = +1
                notabVrai(1, 1) = -1

                notabVrai(0, 2) = -1
                notabVrai(1, 2) = +1

                notabVrai(0, 3) = -1
                notabVrai(1, 3) = +1

                notabVrai(0, 4) = -1
                notabVrai(1, 4) = +1

                notabVrai(0, 5) = +1
                notabVrai(1, 5) = -1

                notabVrai(0, 6) = +1
                notabVrai(1, 6) = -1

                notabVrai(0, 7) = -1
                notabVrai(1, 7) = +1

                notabVrai(0, 8) = -1
                notabVrai(1, 8) = +1

                notabVrai(0, 9) = +1
                notabVrai(1, 9) = -1

                For a = 0 To 1
                    For b = 0 To 9
                        ntqs(a, b) = notabVrai(a, b)
                    Next
                Next

            ElseIf pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
                'renverseNotes()
            End If


            'rNIntro1.Text = tqs(1, 0)
            'rNIntro2.Text = tqs(1, 1)
            'rNIntro3.Text = tqs(1, 2)
            'rNIntro4.Text = tqs(1, 3)
            'rNIntro5.Text = tqs(1, 4)

            'rNIntro6.Text = rtqs(1, 5)
            'rNIntro7.Text = rtqs(1, 6)
            'rNIntro8.Text = rtqs(1, 7)
            'rNIntro9.Text = rtqs(1, 8)
            'rNIntro10.Text = rtqs(1, 9)



        ElseIf test0.Text = "test2" Then

            If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߒ ߡߊ߫ ߓߌ߫ ߝߟߐ߫." Then


                qt(0, 0) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߦߋ߫ ߝߋ߲߫ ߘߋ߲߫ ߞߋߟߋ߲߫ ߠߋ߬ ߞߏߝߐ߫ ߟߊ߫."

                qt(0, 1) = "ߝߋ߲߫ ߠߎ߫ ߘߍ߬ߡߊ߬ߕߐ߮ ߟߋ߫ ߝߘߏ߬ߓߊ߬ߕߐ߮ ߘߌ߫."

                qt(0, 2) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߟߎ߬ ߕߍ߫ ߟߊ߫ ߟߊ߫ ߝߋ߲߫ ߜߘߍ߫ ߟߊ߫ ߝߏ߫ ߡߐ߱ ߟߎ߬ ߘߐߙߐ߲߫."

                qt(0, 3) = "ߗߍ߭ ߣߌ߫ ߡߏ߬ߛߏ ߕߍ߫ ߝߘߏ߬ߓߊ߬ߕߐ߯ ߘߌ߫."

                qt(0, 4) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߦߋ߫ ߝߋ߲߫ ߛߌߦߊߡߊ߲߫ ߛߎ߯ ߞߋߟߋ߲߫ ߕߐ߮ ߟߋ߬ ߘߌ߫."

                qt(0, 5) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߣߌ߫ ߝߘߏ߬ߓߊ߬ߕߐ߮ ߓߍ߯ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߡߝߊߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(0, 6) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߣߌ߫ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߡߊ߲߫ ߞߊ߲߫ ߞߊ߲ߡߊߛߙߋ߫ ߞߏ ߘߐ߫."

                qt(0, 7) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߡߊߦߟߍ߫ ߡߝߊߣߍ߲ ߁ ߔߋ߫ ߟߋ߫ ߡߊ߬."

                qt(0, 8) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߣߊ߬ߝߊ ߞߊ߫ ߓߏ߲߬."

                qt(0, 9) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߦߋ߫ ߝߘߏ߬ߓߊ߬ߕߐ߮ ߞߣߐ߫ ߟߋ߬."


                qt(1, 0) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߦߋ߫ ߝߋ߲߫ ߛߌߦߊߡߊ߲߫ ߠߋ߬ ߞߏߝߐ߫ ߟߊ߫."

                qt(1, 1) = "ߞߏߛߓߍ߫߸ ߊ߬ߟߎ߫ ߘߍ߬ߡߊ߬ ߕߐ߮ ߟߋ߬ ߖߐ߫."

                qt(1, 2) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߘߌ߫ ߛߋ߫ ߟߊ߫ ߟߊ߫ ߝߋ߲߫ ߓߍ߯ ߟߊ߫."

                qt(1, 3) = "ߍ߲߬ߍ߲߫ ߘߋ߬߸ ߏ߬ ߟߎ߬ ߦߋ߫ ߝߘߏ߬ߓߊ߬ߕߐ߮ ߟߋ߬ ߘߌ߫."

                qt(1, 4) = "ߞߏߛߓߍ߫߸ ߊ߬ ߦߋ߫ ߝߋ߲߫ ߛߌߦߊߡߊ߲߫ ߛߎ߯ ߞߋߟߋ߲߫ ߠߋ߬ ߞߏߝߐ߫ ߟߊ߫ ߕߎ߬ߡߊ ߓߍ߯."

                qt(1, 5) = "ߍ߲߬ߍ߲߫߸ ߝߘߏ߬ߓߊ߬ߕߐ߮ ߟߋ߬ ߁ ߔߋ߫ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߡߝߊߣߍ߲ ߡߊ߬."

                qt(1, 6) = "ߤߐ߲ߞߍ߬߸ ߘߐ ߦߋ߫ ߝߋ߲߫ ߛߌߦߊߡߊ߲߫ ߠߋ߬ ߕߐ߮ ߘߐ߫߸ ߘߐ ߦߋ߫ ߝߋ߲߫ ߁ ߠߋ߬ ߕߐ߮ ߘߌ߫."

                qt(1, 7) = "ߍ߲߬ߍ߲߫ ߘߋ߬߸ ߤߊߟߌ߬ ߡߍ߲ ߠߎ߬ ߟߊߓߊ߲ߣߍ߲߫ ߞߊ߲߫ ߡߊߖߌ߯ ߡߝߊߣߍ߲ ߠߎ߬ ߝߣߊ߫ ߡߊ߬."

                qt(1, 8) = "ߊ߬ߥߐ߬߸ߊ߬ ߦߋ߫ ߝߋ߲߫ ߛߌߦߊߡߊ߲߫ ߠߋ߬ ߕߐ߮ ߝߘߏ߬ߓߊ߬ ߝߐߟߌ߫ ߞߍ߫ ߟߊ߫."

                qt(1, 9) = "ߞߏߛߓߍ߫߸ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߦߴߊ߬ ߞߣߐ߫ ߟߋ߬ ߖߐ߫."


                'Faire correspondre les question au lebel question reponses
                AlouQuestions()

                ' la note des questions choisies
                notabVrai(0, 0) = +1
                notabVrai(1, 0) = -1

                notabVrai(0, 1) = -1
                notabVrai(1, 1) = +1

                notabVrai(0, 2) = +1
                notabVrai(1, 2) = -1

                notabVrai(0, 3) = +1
                notabVrai(1, 3) = -1

                notabVrai(0, 4) = -1
                notabVrai(1, 4) = +1

                notabVrai(0, 5) = +1
                notabVrai(1, 5) = -1

                notabVrai(0, 6) = -1
                notabVrai(1, 6) = +1

                notabVrai(0, 7) = +1
                notabVrai(1, 7) = -1

                notabVrai(0, 8) = -1
                notabVrai(1, 8) = +1

                notabVrai(0, 9) = -1
                notabVrai(1, 9) = +1

                For a = 0 To 1
                    For b = 0 To 9
                        ntqs(a, b) = notabVrai(a, b)
                    Next
                Next

            ElseIf pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
                'renverseNotes()
            End If

        ElseIf test0.Text = "test3" Then

            If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߒ ߡߊ߫ ߓߌ߫ ߝߟߐ߫." Then


                qt(0, 0) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߣߌ߫ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߟߊߓߊ߲߫ ߞߊ߲ߡߊߛߙߋ ߦߋ߫ ߁ ߠߋ߬ ߘߌ߫."

                qt(0, 1) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߓߍ߯ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲ߠߊߓߙߊ߬ߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(0, 2) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߠߊߓߙߊ ߡߊ߬ ߕߎ߬ߡߊ ߘߏ߫ ߟߊ߫."

                qt(0, 3) = "ߝߘߏ߬ߓߊ߬ ߞߋߟߋ߲ߠߊߕߐ߮ ߘߏ߫ ߟߋ߬ ߛߋ߲߬ߞߎ߲ ߘߌ߫."

                qt(0, 4) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߕߍ߫ ߛߋ߫ ߞߍ߫ ߟߊ߫ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߘߌ߫."

                qt(0, 5) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߟߎ߬ ߓߍ߯ ߟߊߓߙߊ߬ ߟߊ߫ ߟߋ߬ ߞߘߊߎ߫."

                qt(0, 6) = "ߛߌ߲ߞߐ߲߫ ߝߌ߬ߟߊ߫ ߟߋ߬ ߝߘߏ߬ߓߊ߬ ߞߋߟߋ߲ߠߊߕߐ߮ ߘߐ߫."

                qt(0, 7) = "ߟߊ߬ߞߋ߬ߟߋ߲߬ߧߊ߬ߟߌ ߟߋ߬ ߝߘߏ߬ߓߊ߬ߕߐ߮ ߞߍ߫ ߟߊ߫ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߘߌ߫."

                qt(0, 8) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߓߊ߯ ߟߊߓߙߊ߬ ߸ߊ߬ ߘߌ߫ ߡߊߝߟߌ߬."

                qt(0, 9) = "ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߣߌ߫ ߝߘߏ߬ߓߊ߬ߕߐ߮ ߟߎ߬ ߞߊ߲ߡߊߛߙߋ ߟߐ߲ ߞߎ߲߬ ߛߌ߫ ߕߍ߫."


                qt(1, 0) = "ߍ߲߬ߍ߲߫ ߘߋ߬߸ ߊ߬ߟߎ߬ ߕߍ߫ ߁ ߘߌ߫."

                qt(1, 1) = "ߍ߲߬ߍ߲߫߸ ߝߘߏ߬ߓߊ߬ ߞߋߟߋ߲ߠߊߕߐ߮ ߟߎ߬ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲߫ ߡߝߊߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(1, 2) = "ߐ߲߰ߤߐ߲߫߸ ߊ߬ ߣߴߊ߬ ߟߊ߲߬ߓߋ߬ ߘߊ߫ ߥߟߊ߫ ߞߵߊ߬ ߡߊߝߟߌ߬."

                qt(1, 3) = "ߞߏߛߓߍ߫߸ ߛߋ߲߬ߞߎ߲ ߦߋ߫ ߝߘߏ߬ߓߊ߬ ߞߋߟߋ߲ߠߊߕߐ߮ ߟߋ߬ ߘߌ߫."

                qt(1, 4) = "ߊ߬ ߘߌ߫ ߛߋ߫ ߞߍ߫ ߟߊ߫ ߊ߬ ߘߌ߫ ߞߍ߬߸ ߏ߬ ߟߋ ߟߊ߬ߞߋ߬ߟߋ߲߬ߧߊ߬ߟߌ ߘߌ߫."

                qt(1, 5) = "ߍ߲߬ߍ߲߫߸ ߊ߬ߟߎ߬ ߕߍ߫ ߟߊߓߙߊ߬ ߟߊ߫ ߢߊ߫ ߞߋߟߋ߲߫ ߡߊ߬."

                qt(1, 6) = "ߝߘߏ߬ߓߊ߬ߕߐ߮ ߣߌ߫ ߞߋ߬ߟߋ߲߬ߠߊ߬ߕߐ߮ ߝߌ߬ߟߊ ߓߍ߯ ߛߌ߲ߞߐ߲ ߠߴߊ߬ ߘߐ߫ ߖߐ߫."

                qt(1, 7) = "ߝߋߎ߫߸ ߊ߬ ߦߴߏ߬ ߟߋ ߞߍ߫ ߟߊ߫ ߖߐ߫."

                qt(1, 8) = "ߌ ߕߎ߬ߢߊ߬߸ ߡߊ߬ߝߟߌ߬ߟߌ ߦߴߊ߬ ߟߊߓߙߊ߬ ߞߎ߲ ߘߏ߫ ߟߋ߬ ߘߌ߫."

                qt(1, 9) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߦߋ߫ ߡߐ߰ ߘߍ߬ߡߍ߲߬ ߠߊ߫ ߟߋ߬ ߛߓߍߟߌ ߣߌ߫ ߡߍ߲ߠߌ ߓߍ߯ ߘߐ߫."


                'Faire correspondre les question au lebel question reponses
                AlouQuestions()

                ' la note des questions choisies
                notabVrai(0, 0) = +1
                notabVrai(1, 0) = -1

                notabVrai(0, 1) = +1
                notabVrai(1, 1) = -1

                notabVrai(0, 2) = -1
                notabVrai(1, 2) = +1

                notabVrai(0, 3) = -1
                notabVrai(1, 3) = +1

                notabVrai(0, 4) = +1
                notabVrai(1, 4) = -1

                notabVrai(0, 5) = +1
                notabVrai(1, 5) = -1

                notabVrai(0, 6) = -1
                notabVrai(1, 6) = +1

                notabVrai(0, 7) = -1
                notabVrai(1, 7) = +1

                notabVrai(0, 8) = -1
                notabVrai(1, 8) = +1

                notabVrai(0, 9) = +1
                notabVrai(1, 9) = -1

                For a = 0 To 1
                    For b = 0 To 9
                        ntqs(a, b) = notabVrai(a, b)
                    Next
                Next

            ElseIf pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
                'renverseNotes()
            End If

        End If
    End Sub

    Public Sub chap2()
        If test0.Text = "test0" Then

            'Les notes des questions du test de l'Introduction du Nom 

            If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߒ ߡߊ߫ ߓߌ߫ ߝߟߐ߫." Then

                'ce cas particulier, aloue la valeur string des lebels au variable question à traiter
                qt(0, 0) = "ߕߐ߯ߣߘߐߓߌߟߊ ߦߋ߫ ߓߌ߬ߟߊ߬ ߟߊ߫ ߕߐ߮ ߣߐ߭ ߟߋ߬ ߘߐ߫."
                qt(0, 1) = "ߕߐ߯ߣߘߐߓߌߟߊ ߦߋ߫ ߛߎ߯ ߄ ߠߋ߬ ߘߌ߫."
                qt(0, 2) = "ߞߎߡߟߊ ߦߋ߫ ߞߎߡߊ߫ ߟߊ߫ ߊ߬ ߖߍ߬ߘߍ ߟߋ߫ ߞߊ߲߬."
                qt(0, 3) = "ߞߎߡߊ ߌߘߐ߫ ߡߍ߲ ߞߊ߲߬ ߏ߬ ߟߋ ߞߎߡߊߢߐ߲߮ ߘߌ߫."
                qt(0, 4) = "ߞߎߡߟߊ ߦߋ߫ ߞߎߡߊ߫ ߟߊ߫ ߡߍ߲ ߝߍ߬ ߏ߬ ߟߋ ߞߎߡߊߢߐ߲߮ ߘߌ߫."
                qt(0, 5) = "ߜߘߍ ߦߋ߫ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫ 'ߊ߬' ߟߋ߬ ߟߊ߫."
                qt(0, 6) = "ߞߎߡߟߊ ߕߐ߮ ߦߋ߫ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫ 'ߌ' ߠߋ߬ ߟߊ߫."
                qt(0, 7) = "ߕߐ߯ߣߘߐߓߌߟߊ ߦߴߊ߲ ߕߊ߲߬ߞߊ߬ ߟߊ߫ ߕߐ߮ ߝߐ߫ ߞߏ߫ ߛߌߦߊߡߊ߲ ߠߋ߫ ߡߊ߬."
                qt(0, 8) = "ߞߎߡߊߢߐ߲߮ ߦߋ߫ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫ 'ߒ' ߠߋ߬ ߟߊ߫."
                qt(0, 9) = "ߣߊ߬ߝߊ߬ ߛߍ߫ ߕߍ߫ ߕߐ߯ߣߘߐߓߌߟߊ ߟߎ߬ ߟߊ߫."

                qt(1, 0) = "ߞߏߛߓߍ߫߸ ߊ߬ ߦߋ߫ ߓߌ߬ߟߊ߬ ߟߊ߫ ߕߐ߮ ߟߋ߫ ߣߐ߭ ߘߐ߫."
                qt(1, 1) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߦߋ߫ ߛߎ߯ ߃ ߟߋ߬ ߘߌ߫."
                qt(1, 2) = "ߤߐ߲ߞߍ߬߸ ߞߎߡߟߊ ߦߋ߫ ߞߎߡߊ߫ ߟߊ߫ ߊ߬ ߖߍ߬ߘߍ ߟߋ߫ ߞߊ߲߬."
                qt(1, 3) = "ߍ߲߬ߍ߲߫߸ ߞߎߡߊ ߌߘߐ߫ ߡߍ߲ ߞߊ߲߬ ߏ߬ ߦߋ߫ ߜߘߍ ߟߋ߬ ߘߌ߫."
                qt(1, 4) = "ߞߏߛߓߍ߸ ߞߎߡߊ ߌߘߐ߫ ߡߍ߲ ߝߍ߬ ߏ߬ ߦߋ߫ ߞߎߡߊߢߐ߲߮ ߠߋ߬ ߘߌ߫."
                qt(1, 5) = "ߊ߬ ߦߋ߫ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫ ߏ߬ ߟߋ ߟߊ߫ ߖߐ߫."
                qt(1, 6) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߦߋ߫ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫ 'ߒ' ߠߋ߬ ߟߊ߫."
                qt(1, 7) = "ߞߏߛߓߍ߫ ߞߙߊ߬ߡߐ߰߸ ߞߊ߬ ߢߊߦߋ ߣߐ߰ߦߊ߬ ߝߣߊ߫."
                qt(1, 8) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߦߋ߫ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫ 'ߌ' ߟߋ߬ ߟߊ߫."
                qt(1, 9) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߦߋ߫ ߡߐ߱ ߕߊ߲߬ߞߊ߬ ߟߊ߫ ߕߐ߯ ߁ ߝߐ߫ ߞߏ߫ ߥߙߍ ߟߋ߫ ߡߊ߬."

                'aloue les questions precedentes
                AlouQuestions()

                notabVrai(0, 0) = -1
                notabVrai(1, 0) = +1

                notabVrai(0, 1) = +1
                notabVrai(1, 1) = -1

                notabVrai(0, 2) = -1
                notabVrai(2, 2) = +1

                notabVrai(0, 3) = +1
                notabVrai(1, 3) = -1

                notabVrai(0, 4) = -1
                notabVrai(1, 4) = +1

                notabVrai(0, 5) = -1
                notabVrai(1, 5) = +1

                notabVrai(0, 6) = +1
                notabVrai(1, 6) = -1

                notabVrai(0, 7) = -1
                notabVrai(1, 7) = +1

                notabVrai(0, 8) = +1
                notabVrai(1, 8) = -1

                notabVrai(0, 9) = +1
                notabVrai(1, 9) = -1

                'cette partie recopie le contenu du tableau notaVrai() au tableau ntqs()
                For a = 0 To 1
                    For b = 0 To 9
                        ntqs(a, b) = notabVrai(a, b)
                    Next
                Next


            ElseIf pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
                'renverseNotes()

            End If


            'lesquestions du test du nom presonnel
        ElseIf test0.Text = "test1" Then

            If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߒ ߡߊ߫ ߓߌ߫ ߝߟߐ߫." Then


                qt(0, 0) = "ߕߐ߯ߣߘߐߓߌߟߊ ߕߎ߲߰ߓߊߟߌ ߞߘߐ ߘߌ߫ ߢߊߦߋ߫ ߊ߲߬ ߘߊ߲߬ ߠߊ߫."

                qt(0, 1) = "ߕߎ߲߰ߓߊߟߌ ߟߎ߬ ߦߋ߫ ߛߙߊ߫ ߂ ߟߋ߬ ߘߌ߫."

                qt(0, 2) = "ߕߎ߲߰ߓߊߟߌ ߣߌ߫ ߕߎ߲߰ߕߊ ߓߍ߯ ߦߋ߫ ߛߓߍ߫ ߟߊ߫ ߢߊ߫ ߁ ߠߋ߫ ߡߊ߬."

                qt(0, 3) = "ߕߎ߲߰ߓߊߟߌ ߞߎߡߟߊ ߦߋ߫ ߒߠߋ ߟߋ߬ ߘߌ߫."

                qt(0, 4) = "ߌߟߋ ߕߍ߫ ߕߎ߲߰ߓߊߟߌ ߞߎߡߊߢߐ߲߮ ߘߌ߫."

                qt(0, 5) = "ߟߋ ߓߊ߯ ߓߌ߬ߟߊ߬ ߕߎ߲߰ߕߊ ߟߊ߫ ߊ߬ ߘߌ߫ ߞߍ߫ ߕߎ߲߰ߓߊߟߌ ߘߌ߫."

                qt(0, 6) = "ߕߎ߲߰ߓߊߟߌ ߜߘߍ߫ ߦߋ߫ ߊ߬ߟߋ ߟߋ߬ ߘߌ߫."

                qt(0, 7) = "ߕߎ߲߰ߓߊߟߌ ߓߍ߯ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲ߡߝߊߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(0, 8) = "ߕߎ߲߰ߓߊߟߌ ߣߌ߫ ߕߎ߲߰ߕߊ ߟߎ߬ ߓߍ߯ ߞߘߐ ߘߌ߫ ߢߊߦߋ߫ ߊ߬ߟߎ߬ ߞߏ߫ ߟߊ߫."

                qt(0, 9) = "ߕߐ߯ߣߘߐߓߌߟߊ ߕߎ߲߰ߓߊߟߌ ߕߍ߫ ߓߌ߬ߟߊ߬ ߟߊ߫ ߕߐ߮ ߣߐ߭ ߘߐ߫."


                qt(1, 0) = "ߞߏߛߓߍ߫߸ ߊ߬ߟߋ ߞߘߐ ߘߌ߫ ߢߊߦߋ߫ ߊ߬ ߘߊ߲߬ ߠߊ߫."

                qt(1, 1) = "ߍ߲߬ߍ߲߫߸ ߊ߬ߟߎ߬ ߦߋ߫ ߛߙߊ߫ ߃ ߟߋ߬ ߘߌ߫."

                qt(1, 2) = "ߍ߲߬ߍ߲߫߸ ߊ߬ߟߎ߬ ߕߍ߫ ߛߓߍ߫ ߟߊ߫ ߢߊ߫ ߁ ߡߊ߬."

                qt(1, 3) = "ߞߏߛߓߍ߫߸ ߕߎ߲߰ߓߊߟߌ ߞߎߡߟߊ ߦߋ߫ ߒߠߋ ߟߋ߬ ߘߌ߫."

                qt(1, 4) = "ߍ߲߬ߍ߲߫߸ ߌߟߋ ߦߴߊ߬ ߞߎߡߊߢߐ߲߮ ߠߋ߬ ߘߌ߫."

                qt(1, 5) = "ߌ ߕߎ߬ߢߍ߫߸ ߏ߬ ߟߋ ߖߐ߫."

                qt(1, 6) = "ߝߋߎ߫߸ ߊ߬ ߦߋ߫ ߏ߬ ߟߋ ߘߌ߫ ߖߐ߫."

                qt(1, 7) = "ߊ߯߸ ߌ ߓߘߊ߫ ߢߊߦߋ߫ ߖߐ߫߸ ߊ߬ ߓߍ߯ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲ߡߝߊߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(1, 8) = "ߍ߲߬ߍ߲߫߸ ߕߎ߲߰ߓߊߟߌ ߘߐߙߐ߲߫ ߠߋ߬ ߞߘߐ ߘߌ߫ ߢߊߦߋ߫ ߊ߬ ߞߏ߫ ߟߊ߫."

                qt(1, 9) = "ߍ߲߬ߍ߲߫߸ ߊ߬ߟߎ߬ ߦߋ߫ ߓߌ߬ߟߊ߬ ߟߊ߫ ߏ߬ ߟߋ ߣߐ߭ ߘߐ߫ ߖߐ߫."


                'Faire correspondre les question au lebel question reponses
                AlouQuestions()

                ' la note des questions choisies
                notabVrai(0, 0) = -1
                notabVrai(1, 0) = +1

                notabVrai(0, 1) = +1
                notabVrai(1, 1) = -1

                notabVrai(0, 2) = +1
                notabVrai(1, 2) = -1

                notabVrai(0, 3) = -1
                notabVrai(1, 3) = +1

                notabVrai(0, 4) = +1
                notabVrai(1, 4) = -1

                notabVrai(0, 5) = -1
                notabVrai(1, 5) = +1

                notabVrai(0, 6) = -1
                notabVrai(1, 6) = +1

                notabVrai(0, 7) = -1
                notabVrai(1, 7) = +1

                notabVrai(0, 8) = +1
                notabVrai(1, 8) = -1

                notabVrai(0, 9) = +1
                notabVrai(1, 9) = -1

                For a = 0 To 1
                    For b = 0 To 9
                        ntqs(a, b) = notabVrai(a, b)
                    Next
                Next

            ElseIf pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
                'renverseNotes()
            End If


            'rNIntro1.Text = tqs(1, 0)
            'rNIntro2.Text = tqs(1, 1)
            'rNIntro3.Text = tqs(1, 2)
            'rNIntro4.Text = tqs(1, 3)
            'rNIntro5.Text = tqs(1, 4)

            'rNIntro6.Text = rtqs(1, 5)
            'rNIntro7.Text = rtqs(1, 6)
            'rNIntro8.Text = rtqs(1, 7)
            'rNIntro9.Text = rtqs(1, 8)
            'rNIntro10.Text = rtqs(1, 9)



        ElseIf test0.Text = "test2" Then

            If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߒ ߡߊ߫ ߓߌ߫ ߝߟߐ߫." Then


                qt(0, 0) = "ߕߐ߯ߣߘߐߓߌߟߊ߫ ߦߋ߫ ߛߌ߱ ߂ ߟߋ߬ ߘߌ߫ ߞߊ߬ ߓߍ߲߬ ߝߋ߲߫ ߞߏߝߐߕߊ ߟߎ߬ ߦߙߌߞߊ ߡߊ߬."

                qt(0, 1) = "ߕߐ߯ߣߘߐߓߌߟߊ߫ ߞߋߟߋ߲ߡߊ ߦߋ߫ ߝߋ߲߫ ߁ ߠߋ߬ ߞߏߝߐ߫ ߟߊ߫."

                qt(0, 2) = "ߕߐ߯ߣߘߐߓߌߟߊ߫ ߞߙߎߡߊ ߦߋ߫ ߝߋ߲߫ ߁ ߠߋ߬ ߞߏߝߐ߫ ߟߊ߫."

                qt(0, 3) = "'ߊ߲' ߦߋ߫ ߞߎߡߟߊ߫ ߞߙߎ ߟߋ߫ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫."

                qt(0, 4) = "'ߊ߬ߟߎ߬' ߦߋ߫ ߞߎߡߊߢߐ߲߮ ߠߋ߫ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫ ߞߎߡߊ ߘߐ߫."

                qt(0, 5) = "'ߊߟߎ߫' ߦߋ߫ ߞߎߡߊߢߐ߲߯ ߞߙߎߡߊ ߟߋ߬ ߘߌ߫."

                qt(0, 6) = "ߕߐ߯ߣߘߐߓߌߟߊ߫ ߞߋߟߋ߲ߡߊ ߣߌ߫ ߞߙߎߡߊ ߕߎ߲߰ߕߊ ߣߴߊ߬ ߕߎ߲߰ߓߊߟߌ ߦߴߊ߬ ߘߐ߫."

                qt(0, 7) = "'ߊ߲' ߕߎ߲߰ߓߊߟߌ ߦߋ߫ 'ߊ߲ߠߎ߬' ߟߋ߬ ߘߌ߫."

                qt(0, 8) = "'ߊߟߎ߫' ߕߎ߲߰ߓߊߟߌ ߦߋ߫ 'ߊ߬ߟߎ' ߟߋ߬ ߘߌ߫."

                qt(0, 9) = "'ߊ߬ߟߎ߬' ߕߎ߲߰ߓߊߟߌ ߦߋ߫ 'ߊߟߎ' ߟߋ߬ ߘߌ߫."


                qt(1, 0) = "ߞߏߛߓߍ߫ ߞߙߊ߬ߡߐ߰߸ ߊ߬ߟߎ߬ ߦߋ߫ ߛߌ߱ ߂ ߟߋ߬ ߘߌ߫."

                qt(1, 1) = "ߊ߬ ߦߋ߫ ߕߋ߲߬߸ ߏ߬ ߦߋ߫ ߝߋ߲߫ ߞߋߟߋ߲߫ ߠߋ߬ ߞߏߝߐ߫ ߟߊ߫ ߖߐ߫."

                qt(1, 2) = "ߍ߲߬ߍ߲߫߸ ߏ߬ ߦߋ߫ ߝߋ߲߫ ߞߙߎ ߟߋ߬ ߞߏߝߐ߫ ߟߊ߫."

                qt(1, 3) = "ߞߏߛߓߍ߫߸ ߊ߬ ߦߋ߫ ߞߎߡߟߊ ߣߌ߫ ߡߐ߰ ߜߘߍ߫ ߟߋ߬ ߣߐ߮ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫."

                qt(1, 4) = "ߍ߲߬ߍ߲߫߸ ߊ߬ߟߎ߬ ߦߋ߫ ߜߘߍ߫ ߞߙߎߡߊ ߟߋ߬ ߘߌ߫."

                qt(1, 5) = "ߝߋߎ߫߸ ߏ߬ ߦߋ߫ ߞߎߡߊߢߐ߲߯ ߞߙߎߡߊ ߟߋ߫ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫."

                qt(1, 6) = "ߞߏߛߓߍ߫߸ ߊ߬ߟߎ߬ ߓߍ߯ ߕߎ߲߰ߕߊ ߣߴߊ߬ ߕߎ߲߰ߓߊߟߌ ߦߴߊ߬ ߘߐ߫."

                qt(1, 7) = "ߤߐ߲ߞߍ߬߸ 'ߊ߲' ߕߎ߲߰ߓߊߟߌ ߦߋ߫ 'ߊ߲ߠߎ߬' ߟߋ߬ ߘߌ߫."

                qt(1, 8) = "ߍ߲߬ߍ߲߫߸ ߏ߬ ߦߋ߫ 'ߊߟߎ' ߟߋ߬ ߘߌ߫."

                qt(1, 9) = "ߍ߲߬ߍ߲߫ ߘߋ߬߸ ߏ߬ ߦߋ߫ 'ߊ߬ߟߎ' ߟߋ߬ ߘߌ߫."


                'Faire correspondre les question au lebel question reponses
                AlouQuestions()

                ' la note des questions choisies
                notabVrai(0, 0) = -1
                notabVrai(1, 0) = +1

                notabVrai(0, 1) = -1
                notabVrai(1, 1) = +1

                notabVrai(0, 2) = +1
                notabVrai(1, 2) = -1

                notabVrai(0, 3) = -1
                notabVrai(1, 3) = +1

                notabVrai(0, 4) = +1
                notabVrai(1, 4) = -1

                notabVrai(0, 5) = -1
                notabVrai(1, 5) = +1

                notabVrai(0, 6) = -1
                notabVrai(1, 6) = +1

                notabVrai(0, 7) = -1
                notabVrai(1, 7) = +1

                notabVrai(0, 8) = +1
                notabVrai(1, 8) = -1

                notabVrai(0, 9) = +1
                notabVrai(1, 9) = -1

                For a = 0 To 1
                    For b = 0 To 9
                        ntqs(a, b) = notabVrai(a, b)
                    Next
                Next

            ElseIf pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
                'renverseNotes()
            End If

        ElseIf test0.Text = "test3" Then

            If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߒ ߡߊ߫ ߓߌ߫ ߝߟߐ߫." Then


                qt(0, 0) = "ߕߐ߯ߣߘߐߓߌߟߊ ߘߏ߫ ߟߎ߫ ߦߋ߫ ߂ ߟߋ߬ ߘߌ߫߸ ߦߏ߫ 'ߊ߲' ߣߌ߫ 'ߒ߬'."

                qt(0, 1) = "ߕߐ߯ߣߘߐߓߌߟߊ߫ ߞߘߐߢߐ߲߮ ߠߎ߬ ߕߍ߫ ߛߋ߫ ߢߐ߲߮ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫."

                qt(0, 2) = "'ߊ߲ߠߎ߬' ߣߌ߫ 'ߒ߬ߠߎ߬' ߕߍ߫ ߞߘߐߢߐ߲߯ ߘߌ߫."

                qt(0, 3) = "'ߊ߲' ߣߌ߫ 'ߒ߬' ߓߍ߯ ߞߘߐ߫ ߞߋߟߋ߲߫."

                qt(0, 4) = "ߕߐ߯ߣߘߐߓߌߟߊ ߕߎ߲߰ߕߊ ߟߎ߬ ߓߍ߯ ߟߊߓߙߊ߬ߣߍ߲߫ ߠߋ߬."

                qt(0, 5) = "ߕߐ߯ߣߘߐߓߌߟߊ ߕߎ߲߰ߓߊߟߌ ߝߊ߲߬ߓߊ ߓߍ߯ ߡߝߊߣߍ߲߫ ߠߋ߬."

                qt(0, 6) = "ߞߙߎߡߊ߫ ߞߎߡߟߊ ߕߎ߲߰ߓߊߟߌ ߟߎ߬ ߝߣߊ߫ ߡߝߊߣߍ߲߫ ߠߋ߬."

                qt(0, 7) = "ߕߐ߯ߣߘߐߓߌߟߊ ߕߎ߲߰ߓߊߟߌ ߓߍ߯ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲ߡߊߦߟߍ߫ ߟߊߓߙߊ߬ߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(0, 8) = "ߕߐ߯ߣߘߐߓߌߟߊ ߘߏ߫ ߟߎ߫ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲ߡߊߖߌ߮ ߡߊ߬."

                qt(0, 9) = "ߣߝߊ߬ ߛߌ߫ ߕߍ߫ ߕߐ߯ߣߘߐߓߌߟߊ ߟߎ߬ ߟߊ߫."


                qt(1, 0) = "ߞߏߛߓߍ߫߸ ߏ߬ ߟߎ߬ ߦߋ߫ ߞߘߐߢߐ߲߮ ߠߋ߬ ߘߌ߫."

                qt(1, 1) = "ߍ߲߬ߍ߲߫߸ ߊ߬ߟߎ߬ ߘߌ߫ ߛߋ߫ ߢߐ߲߮ ߣߐ߬ߘߐߓߌ߬ߟߊ߬ ߟߊ߫."

                qt(1, 2) = "ߍ߲߬ߍ߲߫߸ ߊ߬ߟߎ߬ ߦߋ߫ ߞߘߐߢߐ߲߮ ߠߋ߬ ߘߌ߫."

                qt(1, 3) = "ߤߐ߲ߞߍ߬߸ ߏ߬ ߟߎ߬ ߓߍ߯ ߞߘߐ߫ ߞߋߟߋ߲߫."

                qt(1, 4) = "ߞߏߛߓߍ߫߸ ߖߊ߰ ߌ ߓߘߊ߫ ߊ߬ߟߎ߬ ߞߙߐ߬ߛߌ߬ ߝߋߎ߫."

                qt(1, 5) = "ߞߏߛߓߍ߫ ߞߙߊ߬ߡߐ߰߸ ߊ߬ߟߎ߬ ߡߝߊߣߍ߲߫ ߠߋ߬ ߖߐ߫."

                qt(1, 6) = "ߍ߲߬ߍ߲߫߸ ߏ߬ ߟߎ߬ ߟߋ߬ ߘߐߙߐ߲߫ ߠߊߓߙߊ߬ߣߍ߲߫ ߕߎ߲߰ߓߊߟߌ ߟߎ߬ ߘߐ߫."

                qt(1, 7) = "ߍ߲߬ߍ߲߫߸ ߞߎߡߟߊ߫ ߞߙߎߡߊ ߟߎ߬ ߦߋ߫ ߟߊߓߊ߲߫ ߠߊ߫ ߞߊ߲ߡߊߖߌ߯ ߟߊߓߙߊ߬ߣߍ߲ ߠߋ߫ ߡߊ߬."

                qt(1, 8) = "ߞߏߛߓߍ߫߸ ߏ߬ ߟߎ߬ ߦߋ߫ 'ߊ߲ߠߎ߬' ߣߌ߫ 'ߊ߬ߟߎ߬' ߟߋ߬ ߘߌ߫."

                qt(1, 9) = "ߍ߲߬ߍ߲߫߸ ߊ߬ ߦߋ߫ ߡߐ߱ ߕߊ߲߬ߞߊ߬ ߟߊ߫ ߕߐ߮ ߝߐߞߏ߫ ߥߙߍ ߟߋ߫ ߡߊ߬ ߞߎߡߊ ߘߐ߫."


                'Faire correspondre les question au lebel question reponses
                AlouQuestions()

                ' la note des questions choisies
                notabVrai(0, 0) = -1
                notabVrai(1, 0) = +1

                notabVrai(0, 1) = +1
                notabVrai(1, 1) = -1

                notabVrai(0, 2) = +1
                notabVrai(1, 2) = -1

                notabVrai(0, 3) = -1
                notabVrai(1, 3) = +1

                notabVrai(0, 4) = -1
                notabVrai(1, 4) = +1

                notabVrai(0, 5) = -1
                notabVrai(1, 5) = +1

                notabVrai(0, 6) = +1
                notabVrai(1, 6) = -1

                notabVrai(0, 7) = +1
                notabVrai(1, 7) = -1

                notabVrai(0, 8) = -1
                notabVrai(1, 8) = +1

                notabVrai(0, 9) = +1
                notabVrai(1, 9) = -1

                For a = 0 To 1
                    For b = 0 To 9
                        ntqs(a, b) = notabVrai(a, b)
                    Next
                Next

            ElseIf pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
                'renverseNotes()
            End If

        End If
    End Sub
    Private Sub kdoboli_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = 600

        'ce tableau à 2 dimensions contient à l'origine les notes des questions selon leur ordre
        '  origine, il sera modifier par l'appel de la fonction reversOrdreQuestion()


        'il affiche les questions des chapitres

        If chap1Noms.Text.Contains(Form1.atoo.Text) Then
            chap1()
        ElseIf chap1Noms.Text.Contains(Form1.toondobila.Text) Then
            chap2()
        End If



    End Sub
    ' ======== declaration d'un tableau de stock des question ========
    'les questions, renverse l'ordre des questions
    Public tqs(2, 10) As String

    'renverse l'ordre des questions et reponses
    Public rtqs(2, 10) As String

    'l'ordre normale des notes
    Public ntqs(2, 10) As Integer

    'l'ordre inversé des reponses
    Public rntqs(2, 10) As Integer


    'ces deux tableaux stocque les notes des question de leur index

    'note si la question n'est cochée pour les index (0,x) et cochée pour les index(1,x)
    Public notabVrai(4, 10) As Integer

    ' note si la question n'est pas cochée
    'Dim notabFaux(10) As Integer

    'les 2 variables d'iteration
    ' Public comp1 As Integer
    ' Public comp2 As Integer

    Public Function reversOrdreQuestion()
      

        Dim comp1 As Integer

        For comp1 = 0 To 1

            For comp2 = 0 To 9
                'renvois l'index 0 à l'index 9 pour les questions et reponses
                rtqs(comp1, comp2) = tqs(comp1, 9 - comp2)

                'renvois l'index 0 à l'index 9 pour les les notes vrai et faux
                'notabVrai(comp1 + 2, comp2) = ntqs(comp1, 9 - comp2)
                rntqs(comp1, comp2) = ntqs(comp1, 9 - comp2)
                notabVrai(comp1 + 2, comp2) = rntqs(comp1, comp2)
            Next comp2

        Next comp1

        qNIntro1.Text = rtqs(0, 0)
        qNIntro2.Text = rtqs(0, 1)
        qNIntro3.Text = rtqs(0, 2)
        qNIntro4.Text = rtqs(0, 3)
        qNIntro5.Text = rtqs(0, 4)
        qNIntro6.Text = rtqs(0, 5)
        qNIntro7.Text = rtqs(0, 6)
        qNIntro8.Text = rtqs(0, 7)
        qNIntro9.Text = rtqs(0, 8)
        qNIntro10.Text = rtqs(0, 9)

        rNIntro1.Text = rtqs(1, 0)
        rNIntro2.Text = rtqs(1, 1)
        rNIntro3.Text = rtqs(1, 2)
        rNIntro4.Text = rtqs(1, 3)
        rNIntro5.Text = rtqs(1, 4)
        rNIntro6.Text = rtqs(1, 5)
        rNIntro7.Text = rtqs(1, 6)
        rNIntro8.Text = rtqs(1, 7)
        rNIntro9.Text = rtqs(1, 8)
        rNIntro10.Text = rtqs(1, 9)

    End Function

    Private Sub presACorrigerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles presACorrigerCheckBox.CheckedChanged
        If presACorrigerCheckBox.Checked = True Then
            questionsGroupBox1.ForeColor = Color.Gray
            presACorrigerCheckBox.ForeColor = Color.Black
            corriger.Visible = True
        ElseIf presACorrigerCheckBox.Checked = False Then
            questionsGroupBox1.ForeColor = Color.Black
            presACorrigerCheckBox.ForeColor = Color.Gray
            corriger.Visible = False
        End If
    End Sub

    'cette fonction decoche toutes les questions pour un nouveau test
    Public Function deCheckQuestions(Onon)
        qNIntro1.Checked = Onon
        qNIntro2.Checked = Onon
        qNIntro3.Checked = Onon
        qNIntro4.Checked = Onon
        qNIntro5.Checked = Onon
        qNIntro6.Checked = Onon
        qNIntro7.Checked = Onon
        qNIntro8.Checked = Onon
        qNIntro9.Checked = Onon
        qNIntro10.Checked = Onon
    End Function

    Dim tour As Integer


    'cette fonction refait le jeux en inversant l'ordre des questions
    Public Function refaireTest()
        tour = 2
        noteControlNom1 = 0
        deCheckQuestions(False)
        afficheNote1nom.Visible =
        exo1PreInfo.Text = "ߌ ߟߊߒߠߊ ߞߎߡߦߊ ߟߎ߬ ߘߐߞߍ߫."
        exo1PreInfo.Visible = False
        corriger.Enabled = True
        afficheFautes(False)
        pasPret.Visible = True
        reversOrdreQuestion()
        pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬"
        infoNote.Visible = False
        presACorrigerCheckBox.Checked = False
        presACorrigerCheckBox.Enabled = True
        pasPresEncore.Checked = False

    End Function

    ' la variable qui permet de stocker la note du joueur
    Dim noteControlNom1 As Integer = 0
    Dim noteEnNqo As String

    '--------------- cette fonction verifie si le jeu est repris ou pas
    Public Sub JeuNormalRepris(reprise)
        ' si reprise = 0 le jeu n'est pas repris
        ' si reprise = 2, le jeu est repris


        'Ce control permet d'évaluer les choix, il donne finalement la note trouvée
        If qNIntro1.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 0)

            If notabVrai(0 + reprise, 0) = +1 Then
                rNIntro1.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 0) = -1 Then
                rNIntro1.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro1.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 0)

            If notabVrai(1 + reprise, 0) = +1 Then
                rNIntro1.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 0) = -1 Then
                rNIntro1.ForeColor = Color.DarkRed
            End If

        End If

        If qNIntro2.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 1)

            If notabVrai(0 + reprise, 1) = +1 Then
                rNIntro2.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 1) = -1 Then
                rNIntro2.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro2.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 1)

            If notabVrai(1 + reprise, 1) = +1 Then
                rNIntro2.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 1) = -1 Then
                rNIntro2.ForeColor = Color.DarkRed
            End If

        End If

        If qNIntro3.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 2)

            If notabVrai(0 + reprise, 2) = +1 Then
                rNIntro3.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 2) = -1 Then
                rNIntro3.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro3.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 2)

            If notabVrai(1 + reprise, 2) = +1 Then
                rNIntro3.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 2) = -1 Then
                rNIntro3.ForeColor = Color.DarkRed
            End If

        End If

        If qNIntro4.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 3)

            If notabVrai(0 + reprise, 3) = +1 Then
                rNIntro4.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 3) = -1 Then
                rNIntro4.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro4.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 3)

            If notabVrai(1 + reprise, 3) = +1 Then
                rNIntro4.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 3) = -1 Then
                rNIntro4.ForeColor = Color.DarkRed
            End If

        End If

        If qNIntro5.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 4)

            If notabVrai(0 + reprise, 4) = +1 Then
                rNIntro5.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 4) = -1 Then
                rNIntro5.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro5.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 4)

            If notabVrai(1 + reprise, 4) = +1 Then
                rNIntro5.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 4) = -1 Then
                rNIntro5.ForeColor = Color.DarkRed
            End If

        End If

        If qNIntro6.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 5)

            If notabVrai(0 + reprise, 5) = +1 Then
                rNIntro6.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 5) = -1 Then
                rNIntro6.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro6.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 5)

            If notabVrai(1 + reprise, 5) = +1 Then
                rNIntro6.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 5) = -1 Then
                rNIntro6.ForeColor = Color.DarkRed
            End If

        End If

        If qNIntro7.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 6)

            If notabVrai(0 + reprise, 6) = +1 Then
                rNIntro7.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 6) = -1 Then
                rNIntro7.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro7.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 6)

            If notabVrai(1 + reprise, 6) = +1 Then
                rNIntro7.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 6) = -1 Then
                rNIntro7.ForeColor = Color.DarkRed
            End If

        End If

        If qNIntro8.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 7)

            If notabVrai(0 + reprise, 7) = +1 Then
                rNIntro8.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 7) = -1 Then
                rNIntro8.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro8.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 7)

            If notabVrai(1 + reprise, 7) = +1 Then
                rNIntro8.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 7) = -1 Then
                rNIntro8.ForeColor = Color.DarkRed
            End If

        End If

        If qNIntro9.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 8)

            If notabVrai(0 + reprise, 8) = +1 Then
                rNIntro9.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 8) = -1 Then
                rNIntro9.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro9.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 8)

            If notabVrai(1 + reprise, 8) = +1 Then
                rNIntro9.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 8) = -1 Then
                rNIntro9.ForeColor = Color.DarkRed
            End If

        End If

        If qNIntro10.Checked = False Then
            noteControlNom1 = noteControlNom1 + notabVrai(0 + reprise, 9)

            If notabVrai(0 + reprise, 9) = +1 Then
                rNIntro10.ForeColor = Color.Green
            ElseIf notabVrai(0 + reprise, 9) = -1 Then
                rNIntro10.ForeColor = Color.DarkRed
            End If

        ElseIf qNIntro10.Checked = True Then
            noteControlNom1 = noteControlNom1 + notabVrai(1 + reprise, 9)

            If notabVrai(1 + reprise, 9) = +1 Then
                rNIntro10.ForeColor = Color.Green
            ElseIf notabVrai(1 + reprise, 9) = -1 Then
                rNIntro10.ForeColor = Color.DarkRed
            End If

        End If
    End Sub

    Public Sub magnalikanNko(kanto, maktili)
        ' on verifie si la personne s'est connectée
        'kanto est une interjection: un petit mot - phrase en nko comme ߋߜߋ߫
        ' maktili: est la critique que subira la personne, ou la felicitaion qu'elle recevra selon sa note

        If My.Settings.Connexion = True Then
            If My.Settings.Genre = "ߛߟߊߕߌ߯" Then
                magnaliNko.Text = kanto & " " & My.Settings.Nom & "ߗߍ" & maktili
            ElseIf My.Settings.Genre = "ߓߐ߬ߟߐ߲߬ߞߊ߫" Then
                magnaliNko.Text = kanto & " " & My.Settings.Nom & "ߡߛߏ" & maktili
            ElseIf My.Settings.Genre = "ߖߏߞߊ߲߫" Then
                magnaliNko.Text = kanto & " " & My.Settings.Nom & "ߡߛߏ" & maktili
            End If
        Else
            magnaliNko.Text = ""
        End If
    End Sub

    Private Sub corriger_Click(sender As Object, e As EventArgs) Handles corriger.Click
        presACorrigerCheckBox.Enabled = False
        'questionsGroupBox1.Enabled = False
        questionsGroupBox1.ForeColor = Color.Gray

        If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߒ ߡߊ߫ ߓߌ߫ ߝߟߐ߫." Then
            JeuNormalRepris(0)
        ElseIf pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
            JeuNormalRepris(2)
        End If

        ' La partie qualificative 
        If noteControlNom1 < 0 Then
            exo1PreInfo.Text = "ߋ߯ ߓߐ ߡߊ߫ ߘߌߦߊ߫ ߛߊ߭ ߟߊ߫߸ ߞߙߊ߬ߡߐ߰ ߟߊ߫ ߖߎ߬ߟߎ ߟߋ߫ ߖߍ߬ߘߍ ߌ ߟߊ߫."
            magnalikanNko("ߔߊߞߌ߰", " ߓߘߊ߫ ߊ߬ ߓߍ߯ ߕߌߢߍ߫.")
            exo1PreInfo.ForeColor = Color.Red
        ElseIf noteControlNom1 = 0 Then
            exo1PreInfo.Text = "ߋߜߋ߫߸ ߤߊߟߌ߬ ߁ ߌ ߡߊ߫ ߊ߬ ߛߐ߬ߘߐ߲߬."
            magnalikanNko("ߤߌ߯", "߸ ߣߌ߲߬ ߞߊ߫ ߦߋ߫ ߌ ߛߊ߬ߣߊ߲߬ߞߎ߲ ߠߎ߬ ߓߟߏ߫ ߖߊ߰ߣߌ߲߬")
            exo1PreInfo.ForeColor = Color.Red
        ElseIf noteControlNom1 > 0 And noteControlNom1 < 5 Then
            exo1PreInfo.Text = "ߤߌ߯ ߞߙߊ߬ߡߐ߰߸ ߊ߬ ߡߊ߫ ߓߍ߲߬ ߝߋߎ߫. ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߌߞߐ߫."
            magnalikanNko("ߋߜߋ߫", "߸ ߌ ߡߊ߫ ߊ߬ ߟߊߞߙߐ߬ߛߌ߫ ߞߊ߬ ߢߊ߬ ߏ߬ ߘߐ߫ ߓߊ߬.")
            exo1PreInfo.ForeColor = Color.DarkOrange
        ElseIf noteControlNom1 >= 5 Then
            exo1PreInfo.Text = "ߌ ߓߘߊ߫ ߌ ߘߐߖߊ߬߸ ߘߏ߫ ߟߊ߫ ߌ ߘߐ߲߬ ߛߋ߲ ߞߊ߲߬"
            magnalikanNko("ߊ߯", "߸ ߝߕߌߣߍ߲߫ ߌ ߡߊ߫ ߛߌ߱ ߓߏ߲߫ ߊ߬ ߞߙߋ ߟߊ߫߹")
            exo1PreInfo.ForeColor = Color.Purple
            If noteControlNom1 >= 8 Then
                exo1PreInfo.Text = "ߌ ߣߌ߫ ߞߏ߲߫߸ ߌ ߘߊ߲߬ߛߐ߰߹"
                magnalikanNko("ߐ߲߬ߤߐ߲ ߖߐ߫", "߸ ߒ ߤߡߊ߬ߣߍ߲߫ ߌ ߡߊ߬ ߕߋ߲߭ ߠߋ߬ ߝߋߎ߫.")
                exo1PreInfo.ForeColor = Color.Blue
                If noteControlNom1 = 10 Then
                    exo1PreInfo.Text = "ߕߋߚߋ߫ ߕߋߞߎ߫߸ ߞߙߊ߬ߡߐ߰ ߝߏ߬ߟߌ ߌ ߢߍ߫."
                    magnalikanNko("ߊ߬ ߛߐߍ", "߸ ߌ ߢߐ߲߰ ߕߍ߫߸ ߌ ߓߟߏ ߞߘߐߕߊ߬.")
                    exo1PreInfo.ForeColor = Color.DarkGreen
                End If
            End If
        End If

        exo1PreInfo.Visible = True
        convertNoteToNqo()
        afficheNote1nom.Visible = True
        infoNote.Visible = True
        corriger.Enabled = False
        If afficheNote1nom.Text.EndsWith("\߁߀") Then
            afficheNote1nom.Text = afficheNote1nom.Text
        Else
            afficheNote1nom.Text = afficheNote1nom.Text & "\߁߀"
        End If

        afficheFautes(True)
        pasPret.Visible = False

        If noteEnNqo < 5 Then
            pasPresEncore.Text = "ߒ ߕߴߊ߬ ߕߏ߫ ߌ ߘߐ߫ ߡߎ߬ߕߎ߲߬."

        ElseIf noteEnNqo >= 5 And noteEnNqo < 8 Then
            pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫."

        ElseIf noteEnNqo >= 8 Then
            '***Afficher un notre exo plus compliquer***
            pasPresEncore.Text = "ߘߏ߫ ߜߘߍ߫ ߟߊߓߐ߫."

            'on affiche pas d'exo avancés car on est au tout debut
            If test0.Text = "test0" Then
                pasPresEncore.Visible = False
            End If


        End If
    End Sub

    'Cette fonction permet de convertir la note trouvée en NKO
    Public Function convertNoteToNqo()
        noteEnNqo = noteControlNom1.ToString
        If noteEnNqo = "0" Then
            afficheNote1nom.Text = "߀"
        ElseIf noteEnNqo = "1" Then
            afficheNote1nom.Text = "߁"
        ElseIf noteEnNqo = "2" Then
            afficheNote1nom.Text = "߂"
        ElseIf noteEnNqo = "3" Then
            afficheNote1nom.Text = "߃"
        ElseIf noteEnNqo = "4" Then
            afficheNote1nom.Text = "߄"
        ElseIf noteEnNqo = "5" Then
            afficheNote1nom.Text = "߅"
        ElseIf noteEnNqo = "6" Then
            afficheNote1nom.Text = "߆"
        ElseIf noteEnNqo = "7" Then
            afficheNote1nom.Text = "߇"
        ElseIf noteEnNqo = "8" Then
            afficheNote1nom.Text = "߈"
        ElseIf noteEnNqo = "9" Then
            afficheNote1nom.Text = "߉"
        ElseIf noteEnNqo = "10" Then
            afficheNote1nom.Text = "߁߀"

        ElseIf noteEnNqo = "-1" Then
            afficheNote1nom.Text = "-߁"
        ElseIf noteEnNqo = "-2" Then
            afficheNote1nom.Text = "-߂"
        ElseIf noteEnNqo = "-3" Then
            afficheNote1nom.Text = "-߃"
        ElseIf noteEnNqo = "-4" Then
            afficheNote1nom.Text = "-߄"
        ElseIf noteEnNqo = "-5" Then
            afficheNote1nom.Text = "-߅"
        ElseIf noteEnNqo = "-6" Then
            afficheNote1nom.Text = "-߆"
        ElseIf noteEnNqo = "-7" Then
            afficheNote1nom.Text = "-߇"
        ElseIf noteEnNqo = "-8" Then
            afficheNote1nom.Text = "-߈"
        ElseIf noteEnNqo = "-9" Then
            afficheNote1nom.Text = "-߉"
        ElseIf noteEnNqo = "-10" Then
            afficheNote1nom.Text = "-߁߀"
        End If

    End Function


    Public Function afficheFautes(Noui)

        Me.Width = 990

        rNIntro1.Visible = Noui
        rNIntro1.Enabled = Noui
        rNIntro2.Visible = Noui
        rNIntro2.Enabled = Noui
        rNIntro3.Visible = Noui
        rNIntro3.Enabled = Noui
        rNIntro4.Visible = Noui
        rNIntro4.Enabled = Noui
        rNIntro5.Visible = Noui
        rNIntro5.Enabled = Noui
        rNIntro6.Visible = Noui
        rNIntro6.Enabled = Noui
        rNIntro7.Visible = Noui
        rNIntro7.Enabled = Noui
        rNIntro8.Visible = Noui
        rNIntro8.Enabled = Noui
        rNIntro9.Visible = Noui
        rNIntro9.Enabled = Noui
        rNIntro10.Visible = Noui
        rNIntro10.Enabled = Noui
    End Function

    Private Sub pasPresEncore_CheckedChanged(sender As Object, e As EventArgs) Handles pasPresEncore.CheckedChanged, pasPresEncore.CheckedChanged

        If pasPresEncore.Text = "ߊ߬ ߡߊߛߊ߬ߦߌ߬ ߞߏ߫ ߞߎߘߊ߫." Or pasPresEncore.Text = "ߊ߬ ߓߘߊ߫ ߡߊߛߊ߬ߦߌ߬" Then
            If pasPresEncore.Checked = True Then
                refaireTest()
                Me.Width = 600
                If Width = 600 Then
                    pasPret.Visible = True
                Else
                    pasPret.Visible = False
                End If

            End If

            'cette partie montre un exo plus compliquer
        ElseIf pasPresEncore.Text = "ߘߏ߫ ߜߘߍ߫ ߟߊߓߐ߫." Then
            Blomaklo.Show()
            Me.Close()

        Else
            If pasPresEncore.Checked = True Then
                Me.Close()

               refaitTest()

            End If
        End If
    End Sub

    Public Sub refaitTest()
        If test0.Text = "test0" Then
            nomAll.Show()
            nomAll.exoActive.Checked = False
            nomAll.exercices.Visible = False

        ElseIf test0.Text = "test1" Then
            Nom1klenatoh.Show()
            Nom1klenatoh.exoActive.Checked = False
            Nom1klenatoh.exercices.Visible = False

        ElseIf test0.Text = "test2" Then
            Nom2fdobatoh.Show()
            Nom2fdobatoh.exoActive.Checked = False
            Nom2fdobatoh.exercices.Visible = False

        ElseIf test0.Text = "test3" Then
            Nom3deima1.Show()
            Nom3deima1.exoActive.Checked = False
            Nom3deima1.exercices.Visible = False

        End If
    End Sub

    Private Sub pasPret_CheckedChanged(sender As Object, e As EventArgs) Handles pasPret.CheckedChanged
        If pasPret.Checked = True Then
            Me.Close()
            refaitTest()
        End If
    End Sub

End Class

