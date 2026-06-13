# Programowanie aplikacji desktopowych zaliczenie
## Adrian Ebertowski 85242, grupa INLN4(hybryda)_SI1

### Zadanie 1 – Układ okna z panelami i przewijaniem

Celem zadania było utworzenie aplikacji WPF zawierającej trzy główne obszary interfejsu użytkownika:
- górny panel poziomy z elementami rozmieszczonymi obok siebie,
- lewy panel pionowy z elementami rozmieszczonymi jeden pod drugim,
- główny obszar roboczy będący pustym kontenerem.
Panele zostały umieszczone w kontrolkach umożliwiających przewijanie zawartości. Pomiędzy elementami zachowano odstępy zgodne z wymaganiami zadania (5–10 px). Zadanie miało na celu zapoznanie się z kontenerami układu (Grid, StackPanel, WrapPanel, ScrollViewer) oraz mechanizmami przewijania w WPF.

### Zadanie 2 – Okno z siatką i stylami przycisków

Celem zadania było zaprojektowanie interfejsu użytkownika przy użyciu kontrolki Grid.
Okno zostało podzielone na:
- górną belkę z przyciskami,
- lewą belkę będącą osobną podsiecią (sub-grid),
- dolną belkę,
- centralny obszar przeznaczony na zawartość.
Dodatkowo zdefiniowano:
- domyślny styl przycisków obowiązujący w całej aplikacji,
- zmianę wyglądu przycisku po najechaniu kursorem oraz kliknięciu,
- lokalny styl przycisków obowiązujący wyłącznie w podsieci,
- alternatywny styl przycisków identyfikowany za pomocą klucza (Style Key).
Zadanie pozwoliło poznać system stylów, zasobów aplikacji oraz mechanizmów formatowania kontrolek w WPF.

### Zadanie 3 – Powiązanie danych (Data Binding)
Celem zadania było utworzenie formularza umożliwiającego wprowadzenie imienia i nazwiska oraz daty urodzenia użytkownika.
W aplikacji wykorzystano:
- mechanizm wiązania danych (Data Binding),
- interfejs INotifyPropertyChanged,
- właściwości automatycznie aktualizujące widok.
Po wpisaniu danych:
- tekst imienia i nazwiska jest dzielony na pierwsze imię oraz nazwisko,
- na podstawie daty urodzenia obliczany jest wiek użytkownika,
- wszystkie wartości są automatycznie odświeżane w interfejsie.
Zadanie miało na celu poznanie wzorca MVVM oraz komunikacji pomiędzy warstwą danych a interfejsem użytkownika.

### Zadanie 4 – Kalkulator
Celem zadania było stworzenie kalkulatora obsługującego podstawowe oraz rozszerzone operacje matematyczne.
Zaimplementowane funkcje:
- dodawanie,
- odejmowanie,
- mnożenie,
- dzielenie,
- potęgowanie,
- pierwiastkowanie,
- odwracanie liczby (1/x).
Kalkulator wykorzystuje mechanizm buforowania argumentów i wyników. Dzięki temu wielokrotne użycie przycisku „=” powoduje ponowne wykonanie ostatniej operacji z użyciem poprzednio wprowadzonego argumentu oraz ostatniego wyniku. Dodatkowo przycisk resetu usuwa wszystkie zapisane wartości i przywraca stan początkowy programu.
Zadanie miało na celu praktyczne wykorzystanie zdarzeń, obsługi kontrolek oraz zarządzania stanem aplikacji w języku C# i technologii WPF.
