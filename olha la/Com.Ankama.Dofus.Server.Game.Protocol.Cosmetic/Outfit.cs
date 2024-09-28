using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C2F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Outfit : IMessage<Outfit>, IMessage, IEquatable<Outfit>, IDeepCloneable<Outfit>, IBufferMessage
{
	[Token(Token = "0x2000C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000C31")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SkinOutfit : IMessage<SkinOutfit>, IMessage, IEquatable<SkinOutfit>, IDeepCloneable<SkinOutfit>, IBufferMessage
		{
			[Token(Token = "0x4002D46")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SkinOutfit> _parser;

			[Token(Token = "0x4002D47")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002D48")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x4002D49")]
			public const int GidFieldNumber = 1;

			[Token(Token = "0x4002D4A")]
			[FieldOffset(Offset = "0x1C")]
			private int gid_;

			[Token(Token = "0x4002D4B")]
			public const int SkinFieldNumber = 2;

			[Token(Token = "0x4002D4C")]
			[FieldOffset(Offset = "0x8")]
			private static readonly int SkinDefaultValue;

			[Token(Token = "0x4002D4D")]
			[FieldOffset(Offset = "0x20")]
			private int skin_;

			[Token(Token = "0x17001C2F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<SkinOutfit> Parser
			{
				[Token(Token = "0x6008062")]
				[Address(RVA = "0xC6CB80", Offset = "0xC6BF80", VA = "0x180C6CB80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001C30")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6008063")]
				[Address(RVA = "0xC6CB00", Offset = "0xC6BF00", VA = "0x180C6CB00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001C31")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6008064")]
				[Address(RVA = "0xC6CD00", Offset = "0xC6C100", VA = "0x180C6CD00", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001C32")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Gid
			{
				[Token(Token = "0x6008068")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6008069")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17001C33")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Skin
			{
				[Token(Token = "0x600806A")]
				[Address(RVA = "0xC6CBD0", Offset = "0xC6BFD0", VA = "0x180C6CBD0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600806B")]
				[Address(RVA = "0x939960", Offset = "0x938D60", VA = "0x180939960")]
				set
				{
				}
			}

			[Token(Token = "0x17001C34")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool HasSkin
			{
				[Token(Token = "0x600806C")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6008065")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SkinOutfit()
			{
			}

			[Token(Token = "0x6008066")]
			[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SkinOutfit(SkinOutfit other)
			{
			}

			[Token(Token = "0x6008067")]
			[Address(RVA = "0xC6C670", Offset = "0xC6BA70", VA = "0x180C6C670", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SkinOutfit Clone()
			{
				return null;
			}

			[Token(Token = "0x600806D")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearSkin()
			{
			}

			[Token(Token = "0x600806E")]
			[Address(RVA = "0xC6C700", Offset = "0xC6BB00", VA = "0x180C6C700", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600806F")]
			[Address(RVA = "0xC6C7C0", Offset = "0xC6BBC0", VA = "0x180C6C7C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SkinOutfit other)
			{
				return default(bool);
			}

			[Token(Token = "0x6008070")]
			[Address(RVA = "0xC6C840", Offset = "0xC6BC40", VA = "0x180C6C840", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6008071")]
			[Address(RVA = "0xC6C990", Offset = "0xC6BD90", VA = "0x180C6C990", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6008072")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6008073")]
			[Address(RVA = "0xC6CC40", Offset = "0xC6C040", VA = "0x180C6CC40", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6008074")]
			[Address(RVA = "0xC6C560", Offset = "0xC6B960", VA = "0x180C6C560", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6008075")]
			[Address(RVA = "0xC6C920", Offset = "0xC6BD20", VA = "0x180C6C920", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SkinOutfit other)
			{
			}

			[Token(Token = "0x6008076")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6008077")]
			[Address(RVA = "0x939700", Offset = "0x938B00", VA = "0x180939700", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002D29")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Outfit> _parser;

	[Token(Token = "0x4002D2A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D2B")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002D2C")]
	public const int UuidFieldNumber = 1;

	[Token(Token = "0x4002D2D")]
	[FieldOffset(Offset = "0x20")]
	private string uuid_;

	[Token(Token = "0x4002D2E")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4002D2F")]
	[FieldOffset(Offset = "0x28")]
	private string name_;

	[Token(Token = "0x4002D30")]
	public const int PictogramIdFieldNumber = 3;

	[Token(Token = "0x4002D31")]
	[FieldOffset(Offset = "0x30")]
	private int pictogramId_;

	[Token(Token = "0x4002D32")]
	public const int ObjectsFieldNumber = 4;

	[Token(Token = "0x4002D33")]
	[FieldOffset(Offset = "0x8")]
	private static readonly MapField<int, Types.SkinOutfit>.Codec _map_objects_codec;

	[Token(Token = "0x4002D34")]
	[FieldOffset(Offset = "0x38")]
	private readonly MapField<int, Types.SkinOutfit> objects_;

	[Token(Token = "0x4002D35")]
	public const int AuraEmoteIdFieldNumber = 5;

	[Token(Token = "0x4002D36")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int AuraEmoteIdDefaultValue;

	[Token(Token = "0x4002D37")]
	[FieldOffset(Offset = "0x40")]
	private int auraEmoteId_;

	[Token(Token = "0x4002D38")]
	public const int OrnamentIdFieldNumber = 6;

	[Token(Token = "0x4002D39")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int OrnamentIdDefaultValue;

	[Token(Token = "0x4002D3A")]
	[FieldOffset(Offset = "0x44")]
	private int ornamentId_;

	[Token(Token = "0x4002D3B")]
	public const int TitleIdFieldNumber = 7;

	[Token(Token = "0x4002D3C")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int TitleIdDefaultValue;

	[Token(Token = "0x4002D3D")]
	[FieldOffset(Offset = "0x48")]
	private int titleId_;

	[Token(Token = "0x4002D3E")]
	public const int EntityLookFieldNumber = 8;

	[Token(Token = "0x4002D3F")]
	[FieldOffset(Offset = "0x50")]
	private EntityLook entityLook_;

	[Token(Token = "0x4002D40")]
	public const int FavoriteFieldNumber = 9;

	[Token(Token = "0x4002D41")]
	[FieldOffset(Offset = "0x58")]
	private bool favorite_;

	[Token(Token = "0x4002D42")]
	public const int LastModifiedFieldNumber = 10;

	[Token(Token = "0x4002D43")]
	[FieldOffset(Offset = "0x60")]
	private string lastModified_;

	[Token(Token = "0x4002D44")]
	public const int FaceIdFieldNumber = 11;

	[Token(Token = "0x4002D45")]
	[FieldOffset(Offset = "0x68")]
	private int faceId_;

	[Token(Token = "0x17001C1E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Outfit> Parser
	{
		[Token(Token = "0x6008036")]
		[Address(RVA = "0xC6B120", Offset = "0xC6A520", VA = "0x180C6B120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C1F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008037")]
		[Address(RVA = "0xC6B000", Offset = "0xC6A400", VA = "0x180C6B000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008038")]
		[Address(RVA = "0xC6B7F0", Offset = "0xC6ABF0", VA = "0x180C6B7F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C21")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Uuid
	{
		[Token(Token = "0x600803C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600803D")]
		[Address(RVA = "0xC6B940", Offset = "0xC6AD40", VA = "0x180C6B940")]
		set
		{
		}
	}

	[Token(Token = "0x17001C22")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x600803E")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600803F")]
		[Address(RVA = "0xC6B8B0", Offset = "0xC6ACB0", VA = "0x180C6B8B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001C23")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PictogramId
	{
		[Token(Token = "0x6008040")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008041")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17001C24")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, Types.SkinOutfit> Objects
	{
		[Token(Token = "0x6008042")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C25")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AuraEmoteId
	{
		[Token(Token = "0x6008043")]
		[Address(RVA = "0xC6AF90", Offset = "0xC6A390", VA = "0x180C6AF90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008044")]
		[Address(RVA = "0xC6B830", Offset = "0xC6AC30", VA = "0x180C6B830")]
		set
		{
		}
	}

	[Token(Token = "0x17001C26")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAuraEmoteId
	{
		[Token(Token = "0x6008045")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C27")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OrnamentId
	{
		[Token(Token = "0x6008047")]
		[Address(RVA = "0xC6B0B0", Offset = "0xC6A4B0", VA = "0x180C6B0B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008048")]
		[Address(RVA = "0xC6B920", Offset = "0xC6AD20", VA = "0x180C6B920")]
		set
		{
		}
	}

	[Token(Token = "0x17001C28")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasOrnamentId
	{
		[Token(Token = "0x6008049")]
		[Address(RVA = "0xAEF3E0", Offset = "0xAEE7E0", VA = "0x180AEF3E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C29")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TitleId
	{
		[Token(Token = "0x600804B")]
		[Address(RVA = "0xC6B170", Offset = "0xC6A570", VA = "0x180C6B170")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600804C")]
		[Address(RVA = "0xC6B930", Offset = "0xC6AD30", VA = "0x180C6B930")]
		set
		{
		}
	}

	[Token(Token = "0x17001C2A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasTitleId
	{
		[Token(Token = "0x600804D")]
		[Address(RVA = "0xAEF400", Offset = "0xAEE800", VA = "0x180AEF400")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C2B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityLook EntityLook
	{
		[Token(Token = "0x600804F")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008050")]
		[Address(RVA = "0x912500", Offset = "0x911900", VA = "0x180912500")]
		set
		{
		}
	}

	[Token(Token = "0x17001C2C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Favorite
	{
		[Token(Token = "0x6008051")]
		[Address(RVA = "0x874E60", Offset = "0x874260", VA = "0x180874E60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008052")]
		[Address(RVA = "0x874F50", Offset = "0x874350", VA = "0x180874F50")]
		set
		{
		}
	}

	[Token(Token = "0x17001C2D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LastModified
	{
		[Token(Token = "0x6008053")]
		[Address(RVA = "0x7D7250", Offset = "0x7D6650", VA = "0x1807D7250")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008054")]
		[Address(RVA = "0xC6B840", Offset = "0xC6AC40", VA = "0x180C6B840")]
		set
		{
		}
	}

	[Token(Token = "0x17001C2E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FaceId
	{
		[Token(Token = "0x6008055")]
		[Address(RVA = "0x878BB0", Offset = "0x877FB0", VA = "0x180878BB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008056")]
		[Address(RVA = "0x878BE0", Offset = "0x877FE0", VA = "0x180878BE0")]
		set
		{
		}
	}

	[Token(Token = "0x6008039")]
	[Address(RVA = "0xC6AEC0", Offset = "0xC6A2C0", VA = "0x180C6AEC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Outfit()
	{
	}

	[Token(Token = "0x600803A")]
	[Address(RVA = "0xC6ADB0", Offset = "0xC6A1B0", VA = "0x180C6ADB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Outfit(Outfit other)
	{
	}

	[Token(Token = "0x600803B")]
	[Address(RVA = "0xC6A230", Offset = "0xC69630", VA = "0x180C6A230", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Outfit Clone()
	{
		return null;
	}

	[Token(Token = "0x6008046")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAuraEmoteId()
	{
	}

	[Token(Token = "0x600804A")]
	[Address(RVA = "0xAEE790", Offset = "0xAEDB90", VA = "0x180AEE790")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearOrnamentId()
	{
	}

	[Token(Token = "0x600804E")]
	[Address(RVA = "0xAEE7B0", Offset = "0xAEDBB0", VA = "0x180AEE7B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearTitleId()
	{
	}

	[Token(Token = "0x6008057")]
	[Address(RVA = "0xC6A4F0", Offset = "0xC698F0", VA = "0x180C6A4F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008058")]
	[Address(RVA = "0xC6A370", Offset = "0xC69770", VA = "0x180C6A370", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(Outfit other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008059")]
	[Address(RVA = "0xC6A6A0", Offset = "0xC69AA0", VA = "0x180C6A6A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600805A")]
	[Address(RVA = "0xC6AB10", Offset = "0xC69F10", VA = "0x180C6AB10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600805B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600805C")]
	[Address(RVA = "0xC6B4E0", Offset = "0xC6A8E0", VA = "0x180C6B4E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600805D")]
	[Address(RVA = "0xC69EE0", Offset = "0xC692E0", VA = "0x180C69EE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600805E")]
	[Address(RVA = "0xC6A960", Offset = "0xC69D60", VA = "0x180C6A960", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(Outfit other)
	{
	}

	[Token(Token = "0x600805F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008060")]
	[Address(RVA = "0xC6B1E0", Offset = "0xC6A5E0", VA = "0x180C6B1E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
