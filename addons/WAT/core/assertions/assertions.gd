extends Reference

const IsNot: Script = preload("is_not.gd")
const Utility: Script = preload("utility.gd")

signal OUTPUT
signal asserted

func output(data) -> void:
	emit_signal("asserted", data)

func loop(method: String, data: Array) -> void:
	for set in data:
		callv(method, set)
	
func that(obj: Object, method: String, arguments: Array = [], context: String = "", passed: String = "", failed: String = "") -> void:
	output(Utility.that(obj, method, arguments, context, passed, failed))

func is_not_bool(value, context: String = "") -> void:
		output(IsNot.is_not_bool(value, context))

func is_not_int(value, context: String = "") -> void:
		output(IsNot.is_not_int(value, context))

func is_not_float(value, context: String = "") -> void:
		output(IsNot.is_not_float(value, context))

func is_not_String(value, context: String = "") -> void:
		output(IsNot.is_not_String(value, context))
		
func is_not_Vector2(value, context: String = "") -> void:
		output(IsNot.is_not_Vector2(value, context))

func is_not_Rect2(value, context: String = "") -> void:
		output(IsNot.is_not_Rect2(value, context))

func is_not_Vector3(value, context: String = "") -> void:
		output(IsNot.is_not_Vector3(value, context))

func is_not_Transform2D(value, context: String = "") -> void:
		output(IsNot.is_not_Transform2D(value, context))

func is_not_Plane(value, context: String = "") -> void:
		output(IsNot.is_not_Plane(value, context))

func is_not_Quat(value, context: String = "") -> void:
		output(IsNot.is_not_Quat(value, context))

func is_not_AABB(value, context: String = "") -> void:
		output(IsNot.is_not_AABB(value, context))

func is_not_Basis(value, context: String = "") -> void:
		output(IsNot.is_not_Basis(value, context))

func is_not_Transform(value, context: String = "") -> void:
		output(IsNot.is_not_Transform(value, context))

func is_not_Color(value, context: String = "") -> void:
		output(IsNot.is_not_Color(value, context))

func is_not_NodePath(value, context: String = "") -> void:
		output(IsNot.is_not_NodePath(value, context))

func is_not_RID(value, context: String = "") -> void:
		output(IsNot.is_not_RID(value, context))

func is_not_Object(value, context: String = "") -> void:
		output(IsNot.is_not_Object(value, context))

func is_not_Dictionary(value, context: String = "") -> void:
		output(IsNot.is_not_Dictionary(value, context))

func is_not_Array(value, context: String = "") -> void:
		output(IsNot.is_not_Array(value, context))

func is_not_PoolByteArray(value, context: String = "") -> void:
		output(IsNot.is_not_PoolByteArray(value, context))

func is_not_PoolIntArray(value, context: String = "") -> void:
		output(IsNot.is_not_PoolIntArray(value, context))

func is_not_PoolRealArray(value, context: String = "") -> void:
		output(IsNot.is_not_PoolRealArray(value, context))

func is_not_PoolStringArray(value, context: String = "") -> void:
		output(IsNot.is_not_PoolStringArray(value, context))

func is_not_PoolVector2Array(value, context: String = "") -> void:
		output(IsNot.is_not_PoolVector2Array(value, context))

func is_not_PoolVector3Array(value, context: String = "") -> void:
		output(IsNot.is_not_PoolVector3Array(value, context))

func is_not_PoolColorArray(value, context: String = "") -> void:
		output(IsNot.is_not_PoolColorArray(value, context))
		
func fail(context: String = "Unimplemented Test") -> void:
		output(Utility.fail(context))
