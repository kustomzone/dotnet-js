module RayTrace

type Vector = { X:float; Y:float; Z:float }

module Vector =
    let Mul k (v:Vector) = { X=k*v.X; Y=k*v.Y; Z=k*v.Z }
    let Sub (v1:Vector) (v2:Vector) = { X=v1.X-v2.X; Y=v1.Y-v2.Y; Z=v1.Z-v2.Z }
    let Add (v1:Vector) (v2:Vector) = { X=v1.X+v2.X; Y=v1.Y+v2.Y; Z=v1.Z+v2.Z }
    let Dot (v1:Vector) (v2:Vector) = v1.X*v2.X + v1.Y*v2.Y + v1.Z*v2.Z
    let Mag (v:Vector) = sqrt(v.X*v.X + v.Y*v.Y + v.Z*v.Z)
