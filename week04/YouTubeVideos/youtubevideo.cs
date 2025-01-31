classDiagram
    class Video {
        - title: string
        - duration: int
        - genre: string
        + get_title(): string
        + get_duration()int
        + get_genre(): string
    }