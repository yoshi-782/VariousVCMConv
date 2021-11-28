import 'package:dakuten/dakuten.dart' as dakuten;
import 'package:unorm_dart/unorm_dart.dart' as unorm;

void main(List<String> arguments) {
  print(conv("だくてんへんかん"));
}

String conv(String txt) {
  var spl = txt.toString().split("");
  var result = "";
  for (var t in spl) {
    var nfd = unorm.nfd(t);
    result += nfd.length > 1 ? "${nfd.substring(0, 1)}゛" : nfd + "゛";
  }

  return result;
}
