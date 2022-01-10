import unicodedata

def dakuten(text: str) -> str:
    def conv(a: str) -> str:
        normalize = unicodedata.normalize("NFD", a)
        return f"{normalize[:1]}゛" if len(normalize) > 1 else f"{normalize}゛"
    
    return "".join(map(lambda a: conv(a), list(text)))

if __name__ == '__main__':
    print(dakuten("だくてんテスト"))
