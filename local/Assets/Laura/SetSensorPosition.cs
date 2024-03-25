using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSensorPosition : MonoBehaviour {

    public GameObject[] DepthSensors;

    private Matrix4x4[] sensorMatrix;

    // D415_8
    
	void Awake()
    {
        sensorMatrix = new Matrix4x4[DepthSensors.Length];

        //Sensor 1
        sensorMatrix[0].m00 = 1.0f; sensorMatrix[0].m01 = 0.0f; sensorMatrix[0].m02 = 0.0f; sensorMatrix[0].m03 = 0.0f;
        sensorMatrix[0].m10 = 0.0f; sensorMatrix[0].m11 = 1.0f; sensorMatrix[0].m12 = 0.0f; sensorMatrix[0].m13 = 0.0f;
        sensorMatrix[0].m20 = 0.0f; sensorMatrix[0].m21 = 0.0f; sensorMatrix[0].m22 = 1.0f; sensorMatrix[0].m23 = 0.0f;
        sensorMatrix[0].m30 = 0.0f; sensorMatrix[0].m31 = 0.0f; sensorMatrix[0].m32 = 0.0f; sensorMatrix[0].m33 = 1.0f;
        MatrixExtensions.SetTransformFromMatrix(DepthSensors[0].transform, ref sensorMatrix[0]);

        // Sensor 2
        sensorMatrix[1].m00 = 7.64333248e-01f; sensorMatrix[1].m01 = 3.69611889e-01f; sensorMatrix[1].m02 =-5.28376579e-01f; sensorMatrix[1].m03 = -6.43777996e-02f;
        sensorMatrix[1].m10 =-5.97605467e-01f; sensorMatrix[1].m11 = 7.13818610e-01f; sensorMatrix[1].m12 =-3.65144730e-01f; sensorMatrix[1].m13 = -2.59720515e-02f;
        sensorMatrix[1].m20 = 2.42203116e-01f; sensorMatrix[1].m21 = 5.94853044e-01f; sensorMatrix[1].m22 = 7.66477406e-01f; sensorMatrix[1].m23 = -3.07725165e-02f;
        sensorMatrix[1].m30 = 0.0f; sensorMatrix[1].m31 = 0.0f; sensorMatrix[1].m32 = 0.0f; sensorMatrix[1].m33 = 1.0f;
        //sensorMatrix[1] = sensorMatrix[0] * sensorMatrix[1];
        MatrixExtensions.SetTransformFromMatrix(DepthSensors[1].transform, ref sensorMatrix[1]);

        //Sensor 3
        sensorMatrix[2].m00 = 7.18042016e-01f; sensorMatrix[2].m01 = 5.18952549e-01f; sensorMatrix[2].m02 =-4.63792920e-01f; sensorMatrix[2].m03 = -4.78524379e-02f;
        sensorMatrix[2].m10 =-5.36263764e-01f; sensorMatrix[2].m11 =-1.22620454e-02f; sensorMatrix[2].m12 =-8.43961418e-01f; sensorMatrix[2].m13 = -9.00981575e-02f;
        sensorMatrix[2].m20 =-4.43662941e-01f; sensorMatrix[2].m21 = 8.54714990e-01f; sensorMatrix[2].m22 = 2.69490749e-01f; sensorMatrix[2].m23 = -7.03129396e-02f;
        sensorMatrix[2].m30 = 0.0f; sensorMatrix[2].m31 = 0.0f; sensorMatrix[2].m32 = 0.0f; sensorMatrix[2].m33 = 1.0f;
        //sensorMatrix[2] = sensorMatrix[1] * sensorMatrix[2];
        MatrixExtensions.SetTransformFromMatrix(DepthSensors[2].transform, ref sensorMatrix[2]);

        //Sensor 4
        sensorMatrix[3].m00 = 1.28419340e-01f; sensorMatrix[3].m01 = 3.58438760e-01f; sensorMatrix[3].m02 =-9.24678385e-01f; sensorMatrix[3].m03 = -8.94467309e-02f;
        sensorMatrix[3].m10 =-6.07441127e-01f; sensorMatrix[3].m11 =-7.08594799e-01f; sensorMatrix[3].m12 =-3.59038413e-01f; sensorMatrix[3].m13 = -2.25264560e-02f;
        sensorMatrix[3].m20 =-7.83915579e-01f; sensorMatrix[3].m21 = 6.07795179e-01f; sensorMatrix[3].m22 = 1.26733184e-01f; sensorMatrix[3].m23 = -7.42148831e-02f;
        sensorMatrix[3].m30 = 0.0f; sensorMatrix[3].m31 = 0.0f; sensorMatrix[3].m32 = 0.0f; sensorMatrix[3].m33 = 1.0f;
        //sensorMatrix[3] = sensorMatrix[2] * sensorMatrix[3];
        MatrixExtensions.SetTransformFromMatrix(DepthSensors[3].transform, ref sensorMatrix[3]);

        //Sensor 5
        sensorMatrix[4].m00 = 4.32247102e-01f; sensorMatrix[4].m01 =-1.99811836e-03f; sensorMatrix[4].m02 =-9.01752889e-01f; sensorMatrix[4].m03 = -8.53510723e-02f;
        sensorMatrix[4].m10 =-3.53900366e-03f; sensorMatrix[4].m11 =-9.99993622e-01f; sensorMatrix[4].m12 = 5.19411813e-04f; sensorMatrix[4].m13 = -2.05373438e-03f;
        sensorMatrix[4].m20 =-9.01748359e-01f; sensorMatrix[4].m21 = 2.96679279e-03f; sensorMatrix[4].m22 =-4.32251453e-01f; sensorMatrix[4].m23 = -1.47919863e-01f;
        sensorMatrix[4].m30 = 0.0f; sensorMatrix[4].m31 = 0.0f; sensorMatrix[4].m32 = 0.0f; sensorMatrix[4].m33 = 1.0f;
        //sensorMatrix[4] = sensorMatrix[3] * sensorMatrix[4];
        MatrixExtensions.SetTransformFromMatrix(DepthSensors[4].transform, ref sensorMatrix[4]);


        //Sensor 6
        sensorMatrix[5].m00 = 1.27087802e-01f; sensorMatrix[5].m01 =-3.97232205e-01f; sensorMatrix[5].m02 =-9.08875763e-01f; sensorMatrix[5].m03 = -7.08572492e-02f;
        sensorMatrix[5].m10 = 5.91143489e-01f; sensorMatrix[5].m11 =-7.05462635e-01f; sensorMatrix[5].m12 = 3.90988111e-01f; sensorMatrix[5].m13 = 1.77096445e-02f;
        sensorMatrix[5].m20 =-7.96491146e-01f; sensorMatrix[5].m21 =-5.86965919e-01f; sensorMatrix[5].m22 = 1.45165533e-01f; sensorMatrix[5].m23 = -7.18094781e-02f;
        sensorMatrix[5].m30 = 0.0f; sensorMatrix[5].m31 = 0.0f; sensorMatrix[5].m32 = 0.0f; sensorMatrix[5].m33 = 1.0f;
        //sensorMatrix[5] = sensorMatrix[4] * sensorMatrix[5];
        MatrixExtensions.SetTransformFromMatrix(DepthSensors[5].transform, ref sensorMatrix[5]);


        //Sensor 7
        sensorMatrix[6].m00 = 7.21043825e-01f; sensorMatrix[6].m01 =-5.39002895e-01f; sensorMatrix[6].m02 =-4.35398161e-01f; sensorMatrix[6].m03 = -4.64415550e-02f;
        sensorMatrix[6].m10 = 5.24324954e-01f; sensorMatrix[6].m11 = 1.36538232e-02f; sensorMatrix[6].m12 = 8.51408839e-01f; sensorMatrix[6].m13 = 9.13854390e-02f;
        sensorMatrix[6].m20 =-4.52966988e-01f; sensorMatrix[6].m21 =-8.42193246e-01f; sensorMatrix[6].m22 = 2.92457700e-01f; sensorMatrix[6].m23 = -6.25550523e-02f;
        sensorMatrix[6].m30 = 0.0f; sensorMatrix[6].m31 = 0.0f; sensorMatrix[6].m32 = 0.0f; sensorMatrix[6].m33 = 1.0f;
        //sensorMatrix[6] = sensorMatrix[5] * sensorMatrix[6];
        MatrixExtensions.SetTransformFromMatrix(DepthSensors[6].transform, ref sensorMatrix[6]);


        //Sensor 8
        sensorMatrix[7].m00 = 7.69435048e-01f; sensorMatrix[7].m01 =-3.91117781e-01f; sensorMatrix[7].m02 =-5.04971802e-01f; sensorMatrix[7].m03 = -6.40677586e-02f;
        sensorMatrix[7].m10 = 6.02016866e-01f; sensorMatrix[7].m11 = 7.08235681e-01f; sensorMatrix[7].m12 = 3.68751764e-01f; sensorMatrix[7].m13 = 1.65271312e-02f;
        sensorMatrix[7].m20 = 2.13413656e-01f; sensorMatrix[7].m21 =-5.87732136e-01f; sensorMatrix[7].m22 = 7.80400872e-01f; sensorMatrix[7].m23 = -2.88779158e-02f;
        sensorMatrix[7].m30 = 0.0f; sensorMatrix[7].m31 = 0.0f; sensorMatrix[7].m32 = 0.0f; sensorMatrix[7].m33 = 1.0f;
        //sensorMatrix[7] = sensorMatrix[6] * sensorMatrix[7];
        MatrixExtensions.SetTransformFromMatrix(DepthSensors[7].transform, ref sensorMatrix[7]);

        //360 Sensor
        //sensorMatrix[8].m00 =-8.46855879e-01f; sensorMatrix[8].m01 = -5.40784793e-04f; sensorMatrix[8].m02 = 5.31822264e-01f; sensorMatrix[8].m03 = -3.72695863e-01f;
        //sensorMatrix[8].m10 =-1.62640549e-02f; sensorMatrix[8].m11 = -9.99505460e-01f; sensorMatrix[8].m12 =-2.69146822e-02f; sensorMatrix[8].m13 = -2.89319386e-03f;
        //sensorMatrix[8].m20 = 5.31573832e-01f; sensorMatrix[8].m21 = -3.14424448e-02f; sensorMatrix[8].m22 = 8.46428096e-01f; sensorMatrix[8].m23 = 1.28873423e-01f;
        //sensorMatrix[8].m30 = 0.0f; sensorMatrix[8].m31 = 0.0f; sensorMatrix[8].m32 = 0.0f; sensorMatrix[8].m33 = 1.0f;
        //Matrix4x4 sensorMat = sensorMatrix[4] * sensorMatrix[8];
        //MatrixExtensions.SetTransformFromMatrix(DepthSensors[8].transform, ref sensorMat);
    }
    

    // D435_8_flat
    //void Awake()
    //{
    //    sensorMatrix = new Matrix4x4[DepthSensors.Length];

    //    //Sensor 1
    //    sensorMatrix[0].m00 = 1.0f; sensorMatrix[0].m01 = 0.0f; sensorMatrix[0].m02 = 0.0f; sensorMatrix[0].m03 = 0.0f;
    //    sensorMatrix[0].m10 = 0.0f; sensorMatrix[0].m11 = 1.0f; sensorMatrix[0].m12 = 0.0f; sensorMatrix[0].m13 = 0.0f;
    //    sensorMatrix[0].m20 = 0.0f; sensorMatrix[0].m21 = 0.0f; sensorMatrix[0].m22 = 1.0f; sensorMatrix[0].m23 = 0.0f;
    //    sensorMatrix[0].m30 = 0.0f; sensorMatrix[0].m31 = 0.0f; sensorMatrix[0].m32 = 0.0f; sensorMatrix[0].m33 = 1.0f;

    //    MatrixExtensions.SetTransformFromMatrix(DepthSensors[0].transform, ref sensorMatrix[0]);

    //    //Sensor 2
    //    sensorMatrix[1].m00 = 0.802785f; sensorMatrix[1].m01 = 0.399442f; sensorMatrix[1].m02 = -0.442699f; sensorMatrix[1].m03 = -27.9338f / 1000.0f;
    //    sensorMatrix[1].m10 = -0.575783f; sensorMatrix[1].m11 = 0.712253f; sensorMatrix[1].m12 = -0.401459f; sensorMatrix[1].m13 = -68.2253f / 1000.0f;
    //    sensorMatrix[1].m20 = 0.154954f; sensorMatrix[1].m21 = 0.577184f; sensorMatrix[1].m22 = 0.801778f; sensorMatrix[1].m23 = -22.3125f / 1000.0f;
    //    sensorMatrix[1].m30 = 0.0f; sensorMatrix[1].m31 = 0.0f; sensorMatrix[1].m32 = 0.0f; sensorMatrix[1].m33 = 1.0f;

    //    MatrixExtensions.SetTransformFromMatrix(DepthSensors[1].transform, ref sensorMatrix[1]);

    //    //Sensor 3
    //    sensorMatrix[2].m00 = 0.6552348f; sensorMatrix[2].m01 = 0.5811794f; sensorMatrix[2].m02 = -0.482595f; sensorMatrix[2].m03 = -56.29916f / 1000.0f;
    //    sensorMatrix[2].m10 = -0.5893453f; sensorMatrix[2].m11 = -0.006379657f; sensorMatrix[2].m12 = -0.807856f; sensorMatrix[2].m13 = -104.3936f / 1000.0f;
    //    sensorMatrix[2].m20 = -0.4725881f; sensorMatrix[2].m21 = 0.8137505f; sensorMatrix[2].m22 = 0.3383352f; sensorMatrix[2].m23 = -84.19829f / 1000.0f;
    //    sensorMatrix[2].m30 = 0.0f; sensorMatrix[2].m31 = 0.0f; sensorMatrix[2].m32 = 0.0f; sensorMatrix[2].m33 = 1.0f;

    //    MatrixExtensions.SetTransformFromMatrix(DepthSensors[2].transform, ref sensorMatrix[2]);

    //    //Sensor 4
    //    sensorMatrix[3].m00 = 0.1265237f; sensorMatrix[3].m01 = 0.3925723f; sensorMatrix[3].m02 = -0.9109768f; sensorMatrix[3].m03 = -103.9061f / 1000.0f;
    //    sensorMatrix[3].m10 = -0.5877992f; sensorMatrix[3].m11 = -0.7100891f; sensorMatrix[3].m12 = -0.3876409f; sensorMatrix[3].m13 = -70.17028f / 1000.0f;
    //    sensorMatrix[3].m20 = -0.7990518f; sensorMatrix[3].m21 = 0.5845172f; sensorMatrix[3].m22 = 0.1409106f; sensorMatrix[3].m23 = -135.1389f / 1000.0f;
    //    sensorMatrix[3].m30 = 0.0f; sensorMatrix[3].m31 = 0.0f; sensorMatrix[3].m32 = 0.0f; sensorMatrix[3].m33 = 1.0f;

    //    MatrixExtensions.SetTransformFromMatrix(DepthSensors[3].transform, ref sensorMatrix[3]);


    //    //Sensor 5
    //    sensorMatrix[4].m00 = 0.3325598f; sensorMatrix[4].m01 = -0.009966301f; sensorMatrix[4].m02 = -0.9430295f; sensorMatrix[4].m03 = -111.0238f / 1000.0f;
    //    sensorMatrix[4].m10 = -0.007500229f; sensorMatrix[4].m11 = -0.9999405f; sensorMatrix[4].m12 = 0.007922799f; sensorMatrix[4].m13 = 2.949353f / 1000.0f;
    //    sensorMatrix[4].m20 = -0.9430523f; sensorMatrix[4].m21 = 0.004438132f; sensorMatrix[4].m22 = -0.3326148f; sensorMatrix[4].m23 = -170.062f / 1000.0f;
    //    sensorMatrix[4].m30 = 0.0f; sensorMatrix[4].m31 = 0.0f; sensorMatrix[4].m32 = 0.0f; sensorMatrix[4].m33 = 1.0f / 1000.0f;

    //    MatrixExtensions.SetTransformFromMatrix(DepthSensors[4].transform, ref sensorMatrix[4]);


    //    //Sensor 6
    //    sensorMatrix[5].m00 = 0.1512876f; sensorMatrix[5].m01 = -0.4148401f; sensorMatrix[5].m02 = -0.8972289f; sensorMatrix[5].m03 = -107.6933f / 1000.0f;
    //    sensorMatrix[5].m10 = 0.5782953f; sensorMatrix[5].m11 = -0.6989927f; sensorMatrix[5].m12 = 0.4206943f; sensorMatrix[5].m13 = 70.94596f / 1000.0f;
    //    sensorMatrix[5].m20 = -0.8016774f; sensorMatrix[5].m21 = -0.5825091f; sensorMatrix[5].m22 = 0.1341512f; sensorMatrix[5].m23 = -134.176f / 1000.0f;
    //    sensorMatrix[5].m30 = 0.0f; sensorMatrix[5].m31 = 0.0f; sensorMatrix[5].m32 = 0.0f; sensorMatrix[5].m33 = 1.0f / 1000.0f;

    //    MatrixExtensions.SetTransformFromMatrix(DepthSensors[5].transform, ref sensorMatrix[5]);


    //    //Sensor 7
    //    sensorMatrix[6].m00 = 0.670069f; sensorMatrix[6].m01 = -0.579217f; sensorMatrix[6].m02 = -0.464236f; sensorMatrix[6].m03 = -50.3401f / 1000.0f;
    //    sensorMatrix[6].m10 = 0.567558f; sensorMatrix[6].m11 = 0.00330632f; sensorMatrix[6].m12 = 0.823327f; sensorMatrix[6].m13 = 98.081f / 1000.0f;
    //    sensorMatrix[6].m20 = -0.47842f; sensorMatrix[6].m21 = -0.815167f; sensorMatrix[6].m22 = 0.326524f; sensorMatrix[6].m23 = -92.2786f / 1000.0f;
    //    sensorMatrix[6].m30 = 0.0f; sensorMatrix[6].m31 = 0.0f; sensorMatrix[6].m32 = 0.0f; sensorMatrix[6].m33 = 1.0f / 1000.0f;

    //    MatrixExtensions.SetTransformFromMatrix(DepthSensors[6].transform, ref sensorMatrix[6]);


    //    //Sensor 8
    //    sensorMatrix[7].m00 = 0.814907f; sensorMatrix[7].m01 = -0.390729f; sensorMatrix[7].m02 = -0.428087f; sensorMatrix[7].m03 = -27.4391f / 1000.0f;
    //    sensorMatrix[7].m10 = 0.560998f; sensorMatrix[7].m11 = 0.717324f; sensorMatrix[7].m12 = 0.413192f; sensorMatrix[7].m13 = 68.8834f / 1000.0f;
    //    sensorMatrix[7].m20 = 0.145631f; sensorMatrix[7].m21 = -0.576869f; sensorMatrix[7].m22 = 0.80375f; sensorMatrix[7].m23 = -21.9776f / 1000.0f;
    //    sensorMatrix[7].m30 = 0.0f; sensorMatrix[7].m31 = 0.0f; sensorMatrix[7].m32 = 0.0f; sensorMatrix[7].m33 = 1.0f / 1000.0f;

    //    MatrixExtensions.SetTransformFromMatrix(DepthSensors[7].transform, ref sensorMatrix[7]);
    //}
}
