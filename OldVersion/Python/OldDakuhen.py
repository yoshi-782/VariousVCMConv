import json
import sys

marks: dict = None

def main():
    loadMark()
    print(dakuten(sys.argv[1]))

def loadMark() -> dict:
    json_open = open("mark.json", "r", encoding="utf-8")
    global marks
    marks = json.load(json_open)

def dakuten(value: str) -> str:
    def conv(ch: str) -> str:
        if ch in marks["skip"]:
            return ch
        elif ch in marks["dakuten"]:
            return f"{marks['nomal'][marks['dakuten'].index(ch)]}゛"
        else:
            return f"{ch}゛"

    return "".join([conv(ch) for ch in value])

if __name__ == "__main__":
    main()
