# TestVision

Napisz aplikację, która pozwoli wizualizować wyniki testów na monitorze za pomocą przeglądarki.

Projekt w folderze `src` o nazwie `TestVision` wygenerowany został ze schematu `webapi` z użyciem `.NET 6`.
Nie ma w nim skonfiugorwanej technologi pozwalającej wyświetlić w przeglądarce wyniki testu w formie graficznej.
Dobór tej technologi jest dowolny.

Nie ma restrykcji odnośnie tworzenia wielu projektów w folderze `src` ani wyboru technologii frontendowej.

# Wskazówki

- "maszyna" zapisuje testy do folderu `input` w postaci plików xml
- w ramach zadania dostarczone są przykładowe pliki w folderze `input`, aplikacja powinna reagować na umieszczanie w tym folderze plików podczas działania
- dla dowolnego numeru seryjnego brany jest pod uwagę "najświeższy" wynik testu (może być ich wiele w folderze)

Mile widziane są testy automatyczne.