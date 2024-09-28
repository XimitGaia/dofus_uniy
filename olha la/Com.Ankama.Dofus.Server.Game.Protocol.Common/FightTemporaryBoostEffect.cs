using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A43")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTemporaryBoostEffect : IMessage<FightTemporaryBoostEffect>, IMessage, IEquatable<FightTemporaryBoostEffect>, IDeepCloneable<FightTemporaryBoostEffect>, IBufferMessage
{
	[Token(Token = "0x2000A44")]
	public enum ComplementOneofCase
	{
		[Token(Token = "0x4002514")]
		None = 0,
		[Token(Token = "0x4002515")]
		BoostedSpellId = 2,
		[Token(Token = "0x4002516")]
		WeaponTypeId = 3,
		[Token(Token = "0x4002517")]
		StateId = 4,
		[Token(Token = "0x4002518")]
		Details = 5
	}

	[Token(Token = "0x2000A45")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000A46")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Details : IMessage<Details>, IMessage, IEquatable<Details>, IDeepCloneable<Details>, IBufferMessage
		{
			[Token(Token = "0x4002519")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Details> _parser;

			[Token(Token = "0x400251A")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400251B")]
			public const int FirstParamFieldNumber = 1;

			[Token(Token = "0x400251C")]
			[FieldOffset(Offset = "0x18")]
			private int firstParam_;

			[Token(Token = "0x400251D")]
			public const int SecondParamFieldNumber = 2;

			[Token(Token = "0x400251E")]
			[FieldOffset(Offset = "0x1C")]
			private int secondParam_;

			[Token(Token = "0x400251F")]
			public const int ThirdParamFieldNumber = 3;

			[Token(Token = "0x4002520")]
			[FieldOffset(Offset = "0x20")]
			private int thirdParam_;

			[Token(Token = "0x1700173E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Details> Parser
			{
				[Token(Token = "0x6006B6C")]
				[Address(RVA = "0xBB4450", Offset = "0xBB3850", VA = "0x180BB4450")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700173F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006B6D")]
				[Address(RVA = "0xBB43D0", Offset = "0xBB37D0", VA = "0x180BB43D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001740")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006B6E")]
				[Address(RVA = "0xBB44A0", Offset = "0xBB38A0", VA = "0x180BB44A0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001741")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int FirstParam
			{
				[Token(Token = "0x6006B72")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006B73")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17001742")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SecondParam
			{
				[Token(Token = "0x6006B74")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006B75")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17001743")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int ThirdParam
			{
				[Token(Token = "0x6006B76")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006B77")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6006B6F")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Details()
			{
			}

			[Token(Token = "0x6006B70")]
			[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Details(Details other)
			{
			}

			[Token(Token = "0x6006B71")]
			[Address(RVA = "0xBB4140", Offset = "0xBB3540", VA = "0x180BB4140", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Details Clone()
			{
				return null;
			}

			[Token(Token = "0x6006B78")]
			[Address(RVA = "0xBB41D0", Offset = "0xBB35D0", VA = "0x180BB41D0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006B79")]
			[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Details other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006B7A")]
			[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006B7B")]
			[Address(RVA = "0xBB4270", Offset = "0xBB3670", VA = "0x180BB4270", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006B7C")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006B7D")]
			[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006B7E")]
			[Address(RVA = "0xBB4060", Offset = "0xBB3460", VA = "0x180BB4060", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006B7F")]
			[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Details other)
			{
			}

			[Token(Token = "0x6006B80")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006B81")]
			[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002509")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTemporaryBoostEffect> _parser;

	[Token(Token = "0x400250A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400250B")]
	public const int DeltaFieldNumber = 1;

	[Token(Token = "0x400250C")]
	[FieldOffset(Offset = "0x18")]
	private int delta_;

	[Token(Token = "0x400250D")]
	public const int BoostedSpellIdFieldNumber = 2;

	[Token(Token = "0x400250E")]
	public const int WeaponTypeIdFieldNumber = 3;

	[Token(Token = "0x400250F")]
	public const int StateIdFieldNumber = 4;

	[Token(Token = "0x4002510")]
	public const int DetailsFieldNumber = 5;

	[Token(Token = "0x4002511")]
	[FieldOffset(Offset = "0x20")]
	private object complement_;

	[Token(Token = "0x4002512")]
	[FieldOffset(Offset = "0x28")]
	private ComplementOneofCase complementCase_;

	[Token(Token = "0x17001732")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightTemporaryBoostEffect> Parser
	{
		[Token(Token = "0x6006B49")]
		[Address(RVA = "0xBC1E80", Offset = "0xBC1280", VA = "0x180BC1E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001733")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006B4A")]
		[Address(RVA = "0xBC1D70", Offset = "0xBC1170", VA = "0x180BC1D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001734")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006B4B")]
		[Address(RVA = "0xBC23F0", Offset = "0xBC17F0", VA = "0x180BC23F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001735")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Delta
	{
		[Token(Token = "0x6006B4F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B50")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001736")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BoostedSpellId
	{
		[Token(Token = "0x6006B51")]
		[Address(RVA = "0xBC1D00", Offset = "0xBC1100", VA = "0x180BC1D00")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B52")]
		[Address(RVA = "0xBC2430", Offset = "0xBC1830", VA = "0x180BC2430")]
		set
		{
		}
	}

	[Token(Token = "0x17001737")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasBoostedSpellId
	{
		[Token(Token = "0x6006B53")]
		[Address(RVA = "0xA51710", Offset = "0xA50B10", VA = "0x180A51710")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001738")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int WeaponTypeId
	{
		[Token(Token = "0x6006B55")]
		[Address(RVA = "0xBC1F40", Offset = "0xBC1340", VA = "0x180BC1F40")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B56")]
		[Address(RVA = "0xBC2510", Offset = "0xBC1910", VA = "0x180BC2510")]
		set
		{
		}
	}

	[Token(Token = "0x17001739")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasWeaponTypeId
	{
		[Token(Token = "0x6006B57")]
		[Address(RVA = "0xA51720", Offset = "0xA50B20", VA = "0x180A51720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700173A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StateId
	{
		[Token(Token = "0x6006B59")]
		[Address(RVA = "0xBC1ED0", Offset = "0xBC12D0", VA = "0x180BC1ED0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B5A")]
		[Address(RVA = "0xBC24A0", Offset = "0xBC18A0", VA = "0x180BC24A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700173B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasStateId
	{
		[Token(Token = "0x6006B5B")]
		[Address(RVA = "0xACAA80", Offset = "0xAC9E80", VA = "0x180ACAA80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700173C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Details Details
	{
		[Token(Token = "0x6006B5D")]
		[Address(RVA = "0xBC1E20", Offset = "0xBC1220", VA = "0x180BC1E20")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006B5E")]
		[Address(RVA = "0x9264D0", Offset = "0x9258D0", VA = "0x1809264D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700173D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComplementOneofCase ComplementCase
	{
		[Token(Token = "0x6006B5F")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(ComplementOneofCase);
		}
	}

	[Token(Token = "0x6006B4C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTemporaryBoostEffect()
	{
	}

	[Token(Token = "0x6006B4D")]
	[Address(RVA = "0xBC1B90", Offset = "0xBC0F90", VA = "0x180BC1B90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTemporaryBoostEffect(FightTemporaryBoostEffect other)
	{
	}

	[Token(Token = "0x6006B4E")]
	[Address(RVA = "0xBC1290", Offset = "0xBC0690", VA = "0x180BC1290", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTemporaryBoostEffect Clone()
	{
		return null;
	}

	[Token(Token = "0x6006B54")]
	[Address(RVA = "0xA50F20", Offset = "0xA50320", VA = "0x180A50F20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBoostedSpellId()
	{
	}

	[Token(Token = "0x6006B58")]
	[Address(RVA = "0xA50F40", Offset = "0xA50340", VA = "0x180A50F40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearWeaponTypeId()
	{
	}

	[Token(Token = "0x6006B5C")]
	[Address(RVA = "0xACA300", Offset = "0xAC9700", VA = "0x180ACA300")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearStateId()
	{
	}

	[Token(Token = "0x6006B60")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearComplement()
	{
	}

	[Token(Token = "0x6006B61")]
	[Address(RVA = "0xBC1430", Offset = "0xBC0830", VA = "0x180BC1430", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B62")]
	[Address(RVA = "0xBC1560", Offset = "0xBC0960", VA = "0x180BC1560", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTemporaryBoostEffect other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B63")]
	[Address(RVA = "0xBC1660", Offset = "0xBC0A60", VA = "0x180BC1660", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006B64")]
	[Address(RVA = "0xBC1A30", Offset = "0xBC0E30", VA = "0x180BC1A30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006B65")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006B66")]
	[Address(RVA = "0xBC21B0", Offset = "0xBC15B0", VA = "0x180BC21B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006B67")]
	[Address(RVA = "0xBC1010", Offset = "0xBC0410", VA = "0x180BC1010", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006B68")]
	[Address(RVA = "0xBC1890", Offset = "0xBC0C90", VA = "0x180BC1890", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTemporaryBoostEffect other)
	{
	}

	[Token(Token = "0x6006B69")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006B6A")]
	[Address(RVA = "0xBC1FB0", Offset = "0xBC13B0", VA = "0x180BC1FB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
