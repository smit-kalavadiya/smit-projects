package com.smitpatel.locationsharing;

import androidx.appcompat.app.AppCompatActivity;

import android.app.ProgressDialog;
import android.content.ClipData;
import android.content.Intent;
import android.os.Bundle;
import android.provider.Settings;
import android.content.ClipboardManager;
import android.widget.Toast;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.Collection;
import java.util.HashMap;
import java.util.Objects;

public class View_map extends AppCompatActivity {

    SupportMapFragment supportMapFragment;
    Float longi,lati;
    ProgressDialog progress;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view_map);

        supportMapFragment = (SupportMapFragment) getSupportFragmentManager().findFragmentById(R.id.google_map);
        String android_id = getIntent().getStringExtra("id");


        FirebaseDatabase database = FirebaseDatabase.getInstance();
        DatabaseReference myRef = database.getReference(android_id);

        myRef.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(DataSnapshot dataSnapshot) {

                JSONObject objects = (JSONObject) JSONObject.wrap(dataSnapshot.getValue());


                try {
                    longi = Float.valueOf(objects.getString("Long"));
                    lati = Float.valueOf(objects.getString("Lat"));

                    supportMapFragment.getMapAsync(new OnMapReadyCallback() {
                        @Override
                        public void onMapReady(GoogleMap googleMap) {

                            LatLng latLng = new LatLng(lati,longi);
                            MarkerOptions markerOptions = new MarkerOptions().position(latLng).title("You are here")
                                    .icon(BitmapDescriptorFactory.fromResource(R.drawable.mark) );
                            googleMap.animateCamera(CameraUpdateFactory.newLatLngZoom(latLng,18));
                            googleMap.clear();
                            googleMap.addMarker(markerOptions);

                        }
                    });


                } catch (JSONException e) {
                    e.printStackTrace();
                }

            }

            @Override
            public void onCancelled(DatabaseError error) {
                // Failed to read value
                System.out.println("oyyyy"+error.getMessage());
            }
        });

    }
}