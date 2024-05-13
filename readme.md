ローカライズファイルのxmlでのみ動作確認しています。
Assembly\Base64xmlDecoder.dllを入れてください。

test.xmlなどの中身を

ファイルの中身例
```
<?xml version="1.0" encoding="utf-8"?>
<LanguageData>
  <test.label>てすと</test.label>
</LanguageData>
```


Base64エンコードした下記に差し替えてロードさせる。
前述の内容をUTF-8としてエンコード後、先頭に'base64,'を追加しています。

```
base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4NCjxMYW5ndWFnZURhdGE+DQogIDx0ZXN0LmxhYmVsPuOBpuOBmeOBqDwvdGVzdC5sYWJlbD4NCjwvTGFuZ3VhZ2VEYXRhPg==
```


上記のコードブロック内の文字列は、base64,より後ろの部分をデコードすると同等であることがわかるかと思います。
