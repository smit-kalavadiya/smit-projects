import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';
import 'dart:convert';

class LocationPage extends StatefulWidget {
  const LocationPage({Key? key}) : super(key: key);

  @override
  State<LocationPage> createState() => _LocationPageState();
}

class _LocationPageState extends State<LocationPage> {
  late GoogleMapController mapController;
  final LatLng _center = const LatLng(46.090946, -64.774567);
  List _restaurants = [];
  final Set<Marker> _markers = {};

  Future<void> readJson() async {
    final String response =
        await rootBundle.loadString('assets/locations.json');
    final data = await json.decode(response);
    setState(() {
      _restaurants = data['restaurant'];
    });
  }

  void _addMarker() {
    readJson();
    setState(() {
      for (var i = 0; i < _restaurants.length; i++) {
        String title = "${_restaurants[i]['name']}";
        String snippet = "${_restaurants[i]['city']}";
        _markers.add(Marker(
          markerId: MarkerId(
              LatLng(_restaurants[i]['lat'], _restaurants[i]['lng'])
                  .toString()),
          position: LatLng(_restaurants[i]['lat'], _restaurants[i]['lng']),
          infoWindow: InfoWindow(
            title: title,
            snippet: snippet,
          ),
          icon:
              BitmapDescriptor.defaultMarkerWithHue(BitmapDescriptor.hueYellow),
        ));
      }
    });
  }

  void _onMapCreated(GoogleMapController controller) {
    mapController = controller;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Locations', style: TextStyle(color: Colors.amber)),
        centerTitle: true,
        backgroundColor: Colors.black,
      ),
      body: Stack(
        children: [
          GoogleMap(
            onMapCreated: _onMapCreated,
            markers: _markers,
            initialCameraPosition: CameraPosition(target: _center, zoom: 9),
            zoomControlsEnabled: false,
          ),
          Padding(
            padding: const EdgeInsets.all(16),
            child: Align(
              alignment: Alignment.topRight,
              child: Column(
                children: [
                  const SizedBox(height: 16),
                  FloatingActionButton(
                    tooltip: "Locations",
                    onPressed: () {
                      _addMarker();
                    },
                    materialTapTargetSize: MaterialTapTargetSize.padded,
                    backgroundColor: Colors.black,
                    child: const Icon(
                      Icons.fastfood_rounded,
                      color: Colors.amber,
                      size: 36.0,
                    ),
                  ),
                ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}
