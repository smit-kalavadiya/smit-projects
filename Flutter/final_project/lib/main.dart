import 'package:flutter/material.dart';
import 'dart:convert';
import 'pages/item_details.dart';
import 'package:flutter/services.dart';
import 'package:flutter_native_splash/flutter_native_splash.dart';

void main() {
  FlutterNativeSplash.remove();
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Menu',
      theme: ThemeData(
        primarySwatch: Colors.red,
      ),
      home: const MyHomePage(title: 'Menu'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({Key? key, required this.title}) : super(key: key);
  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  List _items = [];

  Future<void> _getData() async {
    final String response = await rootBundle.loadString("assets/menu.json");
    final data = await json.decode(response);

    setState(() {
      _items = data['menuitem'];
    });
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: ThemeData(scaffoldBackgroundColor: Colors.amber[100]),
      debugShowCheckedModeBanner: false,
      home: Scaffold(
          appBar: AppBar(
            title: const Text(
              'Our Menu',
              style: TextStyle(color: Colors.amber),
            ),
            backgroundColor: Colors.black,
            centerTitle: true,
          ),
          floatingActionButton:
              Row(mainAxisAlignment: MainAxisAlignment.spaceEvenly),
          body: ListView.builder(
              itemCount: _items.length,
              itemBuilder: (
                context,
                index,
              ) {
                return Padding(
                  padding: const EdgeInsets.all(3.0),
                  child: GestureDetector(
                    onTap: () {
                      Navigator.push(
                          context,
                          MaterialPageRoute(
                              builder: (context) => IteamDetails(
                                    details: index.toString(),
                                  )));
                    },
                    child: Card(
                      clipBehavior: Clip.antiAliasWithSaveLayer,
                      child: Column(
                        children: [
                          SizedBox(
                            width: 400,
                            height: 180,
                            child: Image.network(
                              _items[index]['image'].toString(),
                              fit: BoxFit.fitWidth,
                            ),
                          ),
                          Padding(
                            padding: const EdgeInsets.all(20.0),
                            child: Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  _items[index]['name'].toString(),
                                  style: const TextStyle(
                                      fontSize: 18,
                                      fontWeight: FontWeight.bold),
                                ),
                                Text('\$ ' + _items[index]['price'].toString(),
                                    style: const TextStyle(
                                        color: Colors.grey,
                                        fontSize: 18,
                                        fontWeight: FontWeight.bold)),
                              ],
                            ),
                          ),
                        ],
                      ),
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(10.0),
                      ),
                      elevation: 5,
                      margin: EdgeInsets.all(10),
                    ),
                  ),
                );
              })),
    );
  }

  @override
  void initState() {
    super.initState();
    _getData();
  }
}
