package com.smitpatel.locationsharing;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.provider.Settings;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class Android_id extends AppCompatActivity {

    EditText editText;
    Button btn;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_android_id);

        editText = findViewById(R.id.android_id);
        btn = findViewById(R.id.submit);

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {


                if(editText.getText().toString().equals(""))
                {
                    Toast.makeText(getApplicationContext(),"Enter android id first...",Toast.LENGTH_LONG).show();
                }
                else
                {
                    Intent i = new Intent(Android_id.this,View_map.class);
                    i.putExtra("id",editText.getText().toString());
                    startActivity(i);
                }
            }
        });

    }
}