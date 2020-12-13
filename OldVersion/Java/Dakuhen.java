class Dakuhen{
    public static void main(String args[]){
        System.out.println(conv("だくてんテスト"));
    }

    public static String conv(String arg){
        String result = "";
		
		String[] dkata = { "が", "ぎ", "ぐ", "げ", "ご",
                            "ざ", "じ", "ず", "ぜ", "ぞ",
                            "だ", "ぢ", "づ", "で", "ど",
                            "ば", "び", "ぶ", "べ", "ぼ",
                            "ガ", "ギ", "グ", "ゲ", "ゴ",
                            "ザ", "ジ", "ズ", "ゼ", "ゾ",
                            "ダ", "ヂ", "ヅ", "デ", "ド",
                            "バ", "ビ", "ブ", "ベ", "ボ",
                            };
        
		String[] dhira = { "か", "き", "く", "け", "こ",
                            "さ", "し", "す", "せ", "そ",
                            "た", "ち", "つ", "て", "と",
                            "は", "ひ", "ふ", "へ", "ほ",
                            "カ", "キ", "ク", "ケ", "コ",
                            "サ", "シ", "ス", "セ", "ソ",
                            "タ", "チ", "ツ", "テ", "ト",
                            "ハ", "ヒ", "フ", "ヘ", "ホ",
                            };
        
		String[] small = { "ゃ", "ゅ", "ょ",
                            "ャ", "ュ", "ョ",
        };
		
		String[] processing = arg.split("");
		int num = processing.length;
		int numk = dkata.length;
		int nums = small.length;
		
		
		//濁点が付いてる場合の時の処理
		for(int x = 0; x < num; x++){
			for(int y = 0; y < numk; y++){
				if(processing[x].equals(dkata[y])){
					processing[x] = dhira[y];
				}
			}
		}
		
		//濁点(゛)を付ける処理
		int daku = 0;
		for(int a = 0; a < num; a++){
			for(int b = 0; b < nums; b++){
				if(processing[a].equals(small[b])){
                    result += processing[a] + " ";
					daku++;
					break;
				}
			}
		if(0 >= daku){
			result += processing[a] + "゛";
				}
			daku = 0;
            }
            
		return result;
    }
}