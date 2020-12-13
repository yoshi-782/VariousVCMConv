import unicodedata

def dakuten(arg: str):
    return "".join(map(lambda a: conv(a), list(arg)))

def conv(a: str) -> str:
    normalize = unicodedata.normalize("NFD", a)
    return f"{normalize[:1]}゛" if len(normalize) > 1 else f"{normalize}゛"

if __name__ == '__main__':
    print(dakuten("だくてんテスト"))
