package com.example.cuento8d;

import android.animation.ObjectAnimator;
import android.content.Intent;
import android.os.Build;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.widget.ImageView;

public class InteraccionN2 extends AppCompatActivity {
    private ImageView lobito;
    private ObjectAnimator animation;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_interaccion_n2);
        lobito = (ImageView)findViewById(R.id.lobito);
        animation = ObjectAnimator.ofFloat(lobito, "translationX", 400);
        animation.setDuration(6000);

    }

    /*@Override
    public boolean onTouchEvent(MotionEvent event) {
        float x = event.getX();
        float y = event.getY();
        actionLabel.setText("Touch press on x: " + x + " y: " + y);

        Log.i("Prueba", "Funciona");


       move();



        return true;

    }*/

    @Override
    public boolean onTouchEvent(MotionEvent event) {

        switch (event.getAction()) {

            case MotionEvent.ACTION_DOWN:
                move();
                animation.start();
                break;

            case MotionEvent.ACTION_UP:
                animation.end();


        }
        return true;
    }

    private void startScaleAnimation() {
        ObjectAnimator scaleDownX = ObjectAnimator.ofFloat(lobito, "scaleX", 0.8f);
        scaleDownX.setDuration(150);


        scaleDownX.start();

    }





    public void move(){

        animation.start();

        Log.i("Prueba", "animación");
    }

    /*public void pauseAnimation(View view) {
        animation.pause();
    }*/

    public void resumeAnimation(View view) {
        //animation.resume();
    }

}
