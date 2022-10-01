package com.smitpatel.locationsharing;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;

import android.content.ClipData;
import android.content.ClipboardManager;
import android.provider.Settings.Secure;
import android.Manifest;
import android.app.ProgressDialog;
import android.content.pm.PackageManager;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Bundle;
import android.widget.Toast;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class Map extends AppCompatActivity {

    SupportMapFragment supportMapFragment;
    LocationManager mLocationManager;
    ProgressDialog progress;
    DatabaseReference dr1,dr2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_map);

        String android_id = Secure.getString(getApplicationContext().getContentResolver(),
                Secure.ANDROID_ID);

        ClipboardManager clipboard = (ClipboardManager) getSystemService(CLIPBOARD_SERVICE);
        ClipData clip = ClipData.newPlainText(android_id, android_id);
        clipboard.setPrimaryClip(clip);
        Toast.makeText(getApplicationContext(),"Android id Copied",Toast.LENGTH_LONG).show();

        FirebaseDatabase database = FirebaseDatabase.getInstance();
        DatabaseReference myRef = database.getReference(android_id);
        dr1 = myRef.child("Long");
        dr2 = myRef.child("Lat");


        progress = new ProgressDialog(Map.this);
        progress.setTitle("Fetching Location");
        progress.setMessage("Wait while fetching your current location...");
        progress.setCancelable(false); // disable dismiss by tapping outside of the dialog


        supportMapFragment = (SupportMapFragment) getSupportFragmentManager().findFragmentById(R.id.google_map);

        getLocation();
    }

    public void getLocation()
    {
        progress.show();
        mLocationManager = (LocationManager) getSystemService(LOCATION_SERVICE);

        if (ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED && ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
            // TODO: Consider calling
            //    ActivityCompat#requestPermissions
            // here to request the missing permissions, and then overriding
            //   public void onRequestPermissionsResult(int requestCode, String[] permissions,
            //                                          int[] grantResults)
            // to handle the case where the user grants the permission. See the documentation
            // for ActivityCompat#requestPermissions for more details.
            return;
        }

        mLocationManager.requestLocationUpdates(LocationManager.GPS_PROVIDER, 2000,
                0, new LocationListener() {
                    @Override
                    public void onLocationChanged(@NonNull Location location) {
//                        getCurrentLocation();

                        dr1.setValue(location.getLongitude());
                        dr2.setValue(location.getLatitude());

                        supportMapFragment.getMapAsync(new OnMapReadyCallback() {
                            @Override
                            public void onMapReady(GoogleMap googleMap) {

                                LatLng latLng = new LatLng(location.getLatitude(),location.getLongitude());
                                MarkerOptions markerOptions = new MarkerOptions().position(latLng).title("You are here")
                                        .icon(BitmapDescriptorFactory.fromResource(R.drawable.mark) );
                                googleMap.animateCamera(CameraUpdateFactory.newLatLngZoom(latLng,18));
                                googleMap.clear();
                                googleMap.addMarker(markerOptions);

                            }
                        });
                        progress.dismiss();
                    }
                });
    }


}