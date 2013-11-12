Public Class CMain2
    'Stammklasse mit Hauptelementen

    Private titel As String
    Private pic As String       ' Pfadangabe Bild ?
    Private maindir As String   ' Pfadangabe Hauptverzeichnis
    Private dir As String       ' Pfadangabe für Obj
    Private val As Integer      ' Bewertung (1-5) Grafische Darstellung ??
    Private expl As String      ' Kurze Beschreibung (nur in Detailansicht)
    Private stat As Integer     ' 1-3 (gesehen-pausiert-gestoppt)
    Private link As String      ' Link als Verlinkung und zur Infosuche

    Public Sub New(ByVal t As String) ' Titel als Pflichtfeld
        titel = t
        pic = "none"             ' std Bild festlegen


    End Sub


End Class
