import 'package:final_project/pages/location.dart';
import 'package:flutter/material.dart';
import '../main.dart';
import '../pages/location.dart';
import 'dart:convert';
import 'package:flutter/services.dart';

void main() {
  runApp(const MyApp());
}

class IteamDetails extends StatelessWidget {
  const IteamDetails({Key? key, required this.details}) : super(key: key);

  final String details;
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Menu',
      theme: ThemeData(
        primarySwatch: Colors.red,
      ),
      home: MyDetails(details),
    );
  }
}

class MyDetails extends StatefulWidget {
  const MyDetails(String this.details, {Key? key}) : super(key: key);

  final String details;
  @override
  State<MyDetails> createState() => _MyDetailsState(details);
}

class _MyDetailsState extends State<MyDetails> {
  List _items = [];
  int data = 1;
  Future<void> _buildMarkersFromJson() async {
    final String response = await rootBundle.loadString("assets/menu.json");
    final data = await json.decode(response);

    setState(() {
      _items = data['menuitem'];
    });
  }

  _MyDetailsState(this.details);
  String details;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text(
            _items[int.parse(details)]['name'],
            style: TextStyle(color: Colors.amber),
          ),
          backgroundColor: Colors.black,
          centerTitle: true,
        ),
        floatingActionButton: FloatingActionButton.extended(
          onPressed: () {
            Navigator.push(context,
                MaterialPageRoute(builder: (context) => LocationPage()));
          },
          label: const Text(
            'See Location',
            style: TextStyle(color: Colors.amber),
          ),
          icon: const Icon(Icons.location_on),
          backgroundColor: Colors.black,
        ),
        body: Padding(
          padding: const EdgeInsets.all(2.0),
          child: Column(
            children: [
              Card(
                clipBehavior: Clip.antiAliasWithSaveLayer,
                child: SizedBox(
                  width: 400,
                  height: 250,
                  child: Image.network(
                    _items[int.parse(details)]['image'].toString(),
                    fit: BoxFit.fitWidth,
                  ),
                ),
              ),
              Padding(
                padding: const EdgeInsets.all(12.0),
                child: Text(
                  _items[int.parse(details)]['name'],
                  style: TextStyle(fontWeight: FontWeight.bold, fontSize: 25),
                ),
              ),
              Text(
                _items[int.parse(details)]['desc'],
                style: TextStyle(
                    fontWeight: FontWeight.normal,
                    fontSize: 20,
                    color: Colors.grey),
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Padding(
                    padding: const EdgeInsets.all(26.0),
                    child: FloatingActionButton(
                      onPressed: () {
                        setState(() {
                          if (data > 1) {
                            data = data - 1;
                          }
                        });
                      },
                      backgroundColor: Colors.black,
                      child: const Icon(Icons.remove_circle_sharp),
                    ),
                  ),
                  Text(data.toString(),
                      style: const TextStyle(
                          fontWeight: FontWeight.normal,
                          fontSize: 20,
                          color: Colors.black)),
                  Padding(
                    padding: const EdgeInsets.all(26.0),
                    child: FloatingActionButton(
                      onPressed: () {
                        setState(() {
                          data = data + 1;
                        });
                      },
                      backgroundColor: Colors.black,
                      child: const Icon(Icons.add_circle_rounded),
                    ),
                  ),
                ],
              ),
              Padding(
                padding: const EdgeInsets.all(26.0),
                child: FloatingActionButton.extended(
                  onPressed: () {},
                  label: const Text(
                    "Add Item",
                    style: TextStyle(color: Colors.amber),
                  ),
                  icon: const Icon(Icons.add_circle),
                  backgroundColor: Colors.black,
                ),
              ),
            ],
          ),
        ));
  }

  @override
  void initState() {
    super.initState();
    _buildMarkersFromJson();
  }
}
