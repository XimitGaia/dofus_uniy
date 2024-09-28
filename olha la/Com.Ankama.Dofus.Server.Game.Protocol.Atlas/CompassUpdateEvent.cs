using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Atlas;

[Token(Token = "0x2000B80")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CompassUpdateEvent : IMessage<CompassUpdateEvent>, IMessage, IEquatable<CompassUpdateEvent>, IDeepCloneable<CompassUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x2000B81")]
	public enum ComplementOneofCase
	{
		[Token(Token = "0x4002AF8")]
		None = 0,
		[Token(Token = "0x4002AF9")]
		PartyMember = 3,
		[Token(Token = "0x4002AFA")]
		PvpSeek = 4
	}

	[Token(Token = "0x2000B82")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000B83")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PartyMember : IMessage<PartyMember>, IMessage, IEquatable<PartyMember>, IDeepCloneable<PartyMember>, IBufferMessage
		{
			[Token(Token = "0x4002AFB")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PartyMember> _parser;

			[Token(Token = "0x4002AFC")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002AFD")]
			public const int MemberIdFieldNumber = 1;

			[Token(Token = "0x4002AFE")]
			[FieldOffset(Offset = "0x18")]
			private long memberId_;

			[Token(Token = "0x4002AFF")]
			public const int ActiveFieldNumber = 2;

			[Token(Token = "0x4002B00")]
			[FieldOffset(Offset = "0x20")]
			private bool active_;

			[Token(Token = "0x17001AAC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<PartyMember> Parser
			{
				[Token(Token = "0x6007922")]
				[Address(RVA = "0xC246F0", Offset = "0xC23AF0", VA = "0x180C246F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001AAD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6007923")]
				[Address(RVA = "0xC24670", Offset = "0xC23A70", VA = "0x180C24670")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001AAE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6007924")]
				[Address(RVA = "0xC24740", Offset = "0xC23B40", VA = "0x180C24740", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001AAF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long MemberId
			{
				[Token(Token = "0x6007928")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6007929")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17001AB0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Active
			{
				[Token(Token = "0x600792A")]
				[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600792B")]
				[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
				set
				{
				}
			}

			[Token(Token = "0x6007925")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PartyMember()
			{
			}

			[Token(Token = "0x6007926")]
			[Address(RVA = "0x9D4B00", Offset = "0x9D3F00", VA = "0x1809D4B00")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PartyMember(PartyMember other)
			{
			}

			[Token(Token = "0x6007927")]
			[Address(RVA = "0xC24310", Offset = "0xC23710", VA = "0x180C24310", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PartyMember Clone()
			{
				return null;
			}

			[Token(Token = "0x600792C")]
			[Address(RVA = "0xC243A0", Offset = "0xC237A0", VA = "0x180C243A0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600792D")]
			[Address(RVA = "0x9D4790", Offset = "0x9D3B90", VA = "0x1809D4790", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(PartyMember other)
			{
				return default(bool);
			}

			[Token(Token = "0x600792E")]
			[Address(RVA = "0xC24440", Offset = "0xC23840", VA = "0x180C24440", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600792F")]
			[Address(RVA = "0xC24510", Offset = "0xC23910", VA = "0x180C24510", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007930")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007931")]
			[Address(RVA = "0x9D4D20", Offset = "0x9D4120", VA = "0x1809D4D20", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007932")]
			[Address(RVA = "0xC24280", Offset = "0xC23680", VA = "0x180C24280", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007933")]
			[Address(RVA = "0x9D4940", Offset = "0x9D3D40", VA = "0x1809D4940", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(PartyMember other)
			{
			}

			[Token(Token = "0x6007934")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007935")]
			[Address(RVA = "0x9D4C60", Offset = "0x9D4060", VA = "0x1809D4C60", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000B85")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PvpSeek : IMessage<PvpSeek>, IMessage, IEquatable<PvpSeek>, IDeepCloneable<PvpSeek>, IBufferMessage
		{
			[Token(Token = "0x4002B02")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PvpSeek> _parser;

			[Token(Token = "0x4002B03")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002B04")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x4002B05")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x4002B06")]
			public const int TargetNameFieldNumber = 2;

			[Token(Token = "0x4002B07")]
			[FieldOffset(Offset = "0x20")]
			private string targetName_;

			[Token(Token = "0x17001AB1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<PvpSeek> Parser
			{
				[Token(Token = "0x600793A")]
				[Address(RVA = "0xC24D90", Offset = "0xC24190", VA = "0x180C24D90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001AB2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600793B")]
				[Address(RVA = "0xC24D10", Offset = "0xC24110", VA = "0x180C24D10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001AB3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600793C")]
				[Address(RVA = "0xC24EC0", Offset = "0xC242C0", VA = "0x180C24EC0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001AB4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6007940")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6007941")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17001AB5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string TargetName
			{
				[Token(Token = "0x6007942")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007943")]
				[Address(RVA = "0xC24F70", Offset = "0xC24370", VA = "0x180C24F70")]
				set
				{
				}
			}

			[Token(Token = "0x600793D")]
			[Address(RVA = "0xC24CC0", Offset = "0xC240C0", VA = "0x180C24CC0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PvpSeek()
			{
			}

			[Token(Token = "0x600793E")]
			[Address(RVA = "0xC24C10", Offset = "0xC24010", VA = "0x180C24C10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PvpSeek(PvpSeek other)
			{
			}

			[Token(Token = "0x600793F")]
			[Address(RVA = "0xC248B0", Offset = "0xC23CB0", VA = "0x180C248B0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PvpSeek Clone()
			{
				return null;
			}

			[Token(Token = "0x6007944")]
			[Address(RVA = "0xC24980", Offset = "0xC23D80", VA = "0x180C24980", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007945")]
			[Address(RVA = "0x92C840", Offset = "0x92BC40", VA = "0x18092C840", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(PvpSeek other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007946")]
			[Address(RVA = "0x92C8B0", Offset = "0x92BCB0", VA = "0x18092C8B0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6007947")]
			[Address(RVA = "0xC24AB0", Offset = "0xC23EB0", VA = "0x180C24AB0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007948")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007949")]
			[Address(RVA = "0x92CDC0", Offset = "0x92C1C0", VA = "0x18092CDC0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600794A")]
			[Address(RVA = "0xC247F0", Offset = "0xC23BF0", VA = "0x180C247F0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600794B")]
			[Address(RVA = "0xC24A40", Offset = "0xC23E40", VA = "0x180C24A40", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(PvpSeek other)
			{
			}

			[Token(Token = "0x600794C")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600794D")]
			[Address(RVA = "0xC24DE0", Offset = "0xC241E0", VA = "0x180C24DE0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002AED")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CompassUpdateEvent> _parser;

	[Token(Token = "0x4002AEE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002AEF")]
	public const int TypeFieldNumber = 1;

	[Token(Token = "0x4002AF0")]
	[FieldOffset(Offset = "0x18")]
	private CompassType type_;

	[Token(Token = "0x4002AF1")]
	public const int CoordinatesFieldNumber = 2;

	[Token(Token = "0x4002AF2")]
	[FieldOffset(Offset = "0x20")]
	private MapCoordinates coordinates_;

	[Token(Token = "0x4002AF3")]
	public const int PartyMemberFieldNumber = 3;

	[Token(Token = "0x4002AF4")]
	public const int PvpSeekFieldNumber = 4;

	[Token(Token = "0x4002AF5")]
	[FieldOffset(Offset = "0x28")]
	private object complement_;

	[Token(Token = "0x4002AF6")]
	[FieldOffset(Offset = "0x30")]
	private ComplementOneofCase complementCase_;

	[Token(Token = "0x17001AA4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CompassUpdateEvent> Parser
	{
		[Token(Token = "0x6007907")]
		[Address(RVA = "0xC22F10", Offset = "0xC22310", VA = "0x180C22F10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AA5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007908")]
		[Address(RVA = "0xC22E60", Offset = "0xC22260", VA = "0x180C22E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AA6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007909")]
		[Address(RVA = "0xC233D0", Offset = "0xC227D0", VA = "0x180C233D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AA7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CompassType Type
	{
		[Token(Token = "0x600790D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(CompassType);
		}
		[Token(Token = "0x600790E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001AA8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCoordinates Coordinates
	{
		[Token(Token = "0x600790F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007910")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17001AA9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PartyMember PartyMember
	{
		[Token(Token = "0x6007911")]
		[Address(RVA = "0xC22F60", Offset = "0xC22360", VA = "0x180C22F60")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007912")]
		[Address(RVA = "0x91BB80", Offset = "0x91AF80", VA = "0x18091BB80")]
		set
		{
		}
	}

	[Token(Token = "0x17001AAA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.PvpSeek PvpSeek
	{
		[Token(Token = "0x6007913")]
		[Address(RVA = "0xC22FC0", Offset = "0xC223C0", VA = "0x180C22FC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007914")]
		[Address(RVA = "0x91BB40", Offset = "0x91AF40", VA = "0x18091BB40")]
		set
		{
		}
	}

	[Token(Token = "0x17001AAB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ComplementOneofCase ComplementCase
	{
		[Token(Token = "0x6007915")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(ComplementOneofCase);
		}
	}

	[Token(Token = "0x600790A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CompassUpdateEvent()
	{
	}

	[Token(Token = "0x600790B")]
	[Address(RVA = "0xC22BD0", Offset = "0xC21FD0", VA = "0x180C22BD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CompassUpdateEvent(CompassUpdateEvent other)
	{
	}

	[Token(Token = "0x600790C")]
	[Address(RVA = "0xC22380", Offset = "0xC21780", VA = "0x180C22380", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CompassUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007916")]
	[Address(RVA = "0x91A760", Offset = "0x919B60", VA = "0x18091A760")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearComplement()
	{
	}

	[Token(Token = "0x6007917")]
	[Address(RVA = "0xC223E0", Offset = "0xC217E0", VA = "0x180C223E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007918")]
	[Address(RVA = "0xC22500", Offset = "0xC21900", VA = "0x180C22500", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CompassUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007919")]
	[Address(RVA = "0xC225F0", Offset = "0xC219F0", VA = "0x180C225F0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600791A")]
	[Address(RVA = "0xC22A70", Offset = "0xC21E70", VA = "0x180C22A70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600791B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600791C")]
	[Address(RVA = "0xC23280", Offset = "0xC22680", VA = "0x180C23280", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600791D")]
	[Address(RVA = "0xC221E0", Offset = "0xC215E0", VA = "0x180C221E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600791E")]
	[Address(RVA = "0xC22760", Offset = "0xC21B60", VA = "0x180C22760", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CompassUpdateEvent other)
	{
	}

	[Token(Token = "0x600791F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007920")]
	[Address(RVA = "0xC23020", Offset = "0xC22420", VA = "0x180C23020", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
