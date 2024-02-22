Public Class Game
    Inherits System.Web.UI.Page
    Public Class Card
        Public Property Suit As String
        Public Property Rank As Integer
        Public Property rankNames As String
        Public Property ImageFile As String
    End Class

    Shared deck1(51) As Card
    Shared deck2(51) As Card
    Shared index As Integer = 0
    Shared player1Score, player2Score As Integer
    Shared cardsRemaining As Integer = 52
    Shared extraPoint As Integer = 0

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'calls these functions only on first load
        If Not IsPostBack Then
            createDeck()
            Shuffle(deck1)
            remainingCardsLabel.Text = "52"
        End If

    End Sub

    Private Sub createDeck()
        Dim suits() As String = {"Hearts", "Diamonds", "Clubs", "Spades"}
        Dim ranks() As Integer = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}
        Dim rankNames() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"}

        Dim index As Integer = 0
        For Each suit As String In suits
            For i As Integer = 0 To ranks.Length - 1
                Dim card As New Card()
                card.Suit = suit
                card.Rank = ranks(i)
                card.rankNames = rankNames(i)
                card.ImageFile = rankNames(i) & "_of_" & suit.ToLower() & ".png"
                deck1(index) = card
                deck2(index) = card
                index += 1
            Next
        Next
    End Sub

    Private Sub Shuffle(ByRef deck() As Card)
        Dim rand As New Random()
        Dim n As Integer = deck.Length
        While n > 1
            n -= 1
            Dim k As Integer = rand.Next(n + 1)
            Dim temp As Card = deck(k)
            deck(k) = deck(n)
            deck(n) = temp
        End While
    End Sub

    Private Function CompareCards(ByVal card1 As Card, ByVal card2 As Card) As Integer
        If card1.Rank > card2.Rank Then
            Return 1
        ElseIf card1.Rank < card2.Rank Then
            Return 2
        Else
            Return 0
        End If
    End Function

    Public Sub drawButton_Click(sender As Object, e As EventArgs) Handles drawButton.Click

        If index < 52 Then

            player1IM.ImageUrl = String.Format("Images/{0}", deck1(index).ImageFile)
            player2IM.ImageUrl = String.Format("Images/{0}", deck2(index).ImageFile)

            Dim card1 As Card = deck1(index)
            Dim card2 As Card = deck2(index)
            Dim winner As Integer = CompareCards(card1, card2)

            If winner = 1 Then
                ' Player 1 wins
                player1Score += 1 + extraPoint
                player1ScoreLabel.Text = player1Score
                feedbackLabel.Text = deck1(index).rankNames & " of " & deck1(index).Suit & " VS " &
                    deck2(index).rankNames & " of " & deck2(index).Suit & " Player 1 Wins!"
                extraPoint = 0
            ElseIf winner = 2 Then
                ' Player 2 wins
                player2Score += 1 + extraPoint
                player2ScoreLabel.Text = player2Score
                feedbackLabel.Text = deck1(index).rankNames & " of " & deck1(index).Suit & " VS " &
                    deck2(index).rankNames & " of " & deck2(index).Suit & " Player 2 Wins!"
                extraPoint = 0
            ElseIf winner = 0 Then
                feedbackLabel.Text = deck1(index).rankNames & " of " & deck1(index).Suit & " VS " &
                    deck2(index).rankNames & " of " & deck2(index).Suit & " Tie"
                extraPoint += 1
            End If
            index += 1
            cardsRemaining -= 1
            remainingCardsLabel.Text = cardsRemaining
        End If

        gameOver()

    End Sub

    Private Sub gameOver()
        If cardsRemaining = 0 Then
            If player1Score > player2Score Then
                feedbackLabel.Text = "Player 1 has won the game!"
            Else
                feedbackLabel.Text = "Player 2 has won the game!"
            End If
        End If
    End Sub

    Protected Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click
        feedbackLabel.Text = ""
        player1ScoreLabel.Text = ""
        player2ScoreLabel.Text = ""
        remainingCardsLabel.Text = ""
        index = 0
        player1Score = 0
        player2Score = 0
        cardsRemaining = 52
        Shuffle(deck1)
        Shuffle(deck2)
        player1IM.ImageUrl = ""
        player2IM.ImageUrl = ""
    End Sub

    Protected Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        Response.Redirect("HtmlPage1.html")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles shuffleButton.Click
        Shuffle(deck2)
    End Sub
End Class