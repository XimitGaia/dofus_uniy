using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000701")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeTaxCollectorGetEvent : IMessage<ExchangeTaxCollectorGetEvent>, IMessage, IEquatable<ExchangeTaxCollectorGetEvent>, IDeepCloneable<ExchangeTaxCollectorGetEvent>, IBufferMessage
{
	[Token(Token = "0x40018AB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeTaxCollectorGetEvent> _parser;

	[Token(Token = "0x40018AC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018AD")]
	public const int CollectorNameFieldNumber = 1;

	[Token(Token = "0x40018AE")]
	[FieldOffset(Offset = "0x18")]
	private string collectorName_;

	[Token(Token = "0x40018AF")]
	public const int CoordinatesFieldNumber = 2;

	[Token(Token = "0x40018B0")]
	[FieldOffset(Offset = "0x20")]
	private MapExtendedCoordinates coordinates_;

	[Token(Token = "0x40018B1")]
	public const int UserNameFieldNumber = 3;

	[Token(Token = "0x40018B2")]
	[FieldOffset(Offset = "0x28")]
	private string userName_;

	[Token(Token = "0x40018B3")]
	public const int CallerIdFieldNumber = 4;

	[Token(Token = "0x40018B4")]
	[FieldOffset(Offset = "0x30")]
	private long callerId_;

	[Token(Token = "0x40018B5")]
	public const int CallerNameFieldNumber = 5;

	[Token(Token = "0x40018B6")]
	[FieldOffset(Offset = "0x38")]
	private string callerName_;

	[Token(Token = "0x40018B7")]
	public const int PodsFieldNumber = 6;

	[Token(Token = "0x40018B8")]
	[FieldOffset(Offset = "0x40")]
	private int pods_;

	[Token(Token = "0x40018B9")]
	public const int ObjectsFieldNumber = 7;

	[Token(Token = "0x40018BA")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectGidWithQuantity> _repeated_objects_codec;

	[Token(Token = "0x40018BB")]
	[FieldOffset(Offset = "0x48")]
	private readonly RepeatedField<ObjectGidWithQuantity> objects_;

	[Token(Token = "0x40018BC")]
	public const int LookFieldNumber = 8;

	[Token(Token = "0x40018BD")]
	[FieldOffset(Offset = "0x50")]
	private EntityLook look_;

	[Token(Token = "0x1700101C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeTaxCollectorGetEvent> Parser
	{
		[Token(Token = "0x6004B3D")]
		[Address(RVA = "0xAC0900", Offset = "0xABFD00", VA = "0x180AC0900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700101D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004B3E")]
		[Address(RVA = "0xAC0850", Offset = "0xABFC50", VA = "0x180AC0850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700101E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0xAC0DF0", Offset = "0xAC01F0", VA = "0x180AC0DF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700101F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string CollectorName
	{
		[Token(Token = "0x6004B43")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B44")]
		[Address(RVA = "0xAC0F40", Offset = "0xAC0340", VA = "0x180AC0F40")]
		set
		{
		}
	}

	[Token(Token = "0x17001020")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapExtendedCoordinates Coordinates
	{
		[Token(Token = "0x6004B45")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B46")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17001021")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string UserName
	{
		[Token(Token = "0x6004B47")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B48")]
		[Address(RVA = "0xAC0FB0", Offset = "0xAC03B0", VA = "0x180AC0FB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001022")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CallerId
	{
		[Token(Token = "0x6004B49")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004B4A")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001023")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CallerName
	{
		[Token(Token = "0x6004B4B")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B4C")]
		[Address(RVA = "0xAC0ED0", Offset = "0xAC02D0", VA = "0x180AC0ED0")]
		set
		{
		}
	}

	[Token(Token = "0x17001024")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Pods
	{
		[Token(Token = "0x6004B4D")]
		[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x9F30F0", Offset = "0x9F24F0", VA = "0x1809F30F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001025")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectGidWithQuantity> Objects
	{
		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001026")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook Look
	{
		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x912500", Offset = "0x911900", VA = "0x180912500")]
		set
		{
		}
	}

	[Token(Token = "0x6004B40")]
	[Address(RVA = "0xAC0780", Offset = "0xABFB80", VA = "0x180AC0780")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorGetEvent()
	{
	}

	[Token(Token = "0x6004B41")]
	[Address(RVA = "0xAC0660", Offset = "0xABFA60", VA = "0x180AC0660")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorGetEvent(ExchangeTaxCollectorGetEvent other)
	{
	}

	[Token(Token = "0x6004B42")]
	[Address(RVA = "0xABFD70", Offset = "0xABF170", VA = "0x180ABFD70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorGetEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004B52")]
	[Address(RVA = "0xABFEC0", Offset = "0xABF2C0", VA = "0x180ABFEC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B53")]
	[Address(RVA = "0xAC0020", Offset = "0xABF420", VA = "0x180AC0020", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeTaxCollectorGetEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B54")]
	[Address(RVA = "0xAC0140", Offset = "0xABF540", VA = "0x180AC0140", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004B55")]
	[Address(RVA = "0xAC0460", Offset = "0xABF860", VA = "0x180AC0460", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004B56")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004B57")]
	[Address(RVA = "0xAC0C20", Offset = "0xAC0020", VA = "0x180AC0C20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004B58")]
	[Address(RVA = "0xABFB60", Offset = "0xABEF60", VA = "0x180ABFB60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004B59")]
	[Address(RVA = "0xAC02A0", Offset = "0xABF6A0", VA = "0x180AC02A0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeTaxCollectorGetEvent other)
	{
	}

	[Token(Token = "0x6004B5A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004B5B")]
	[Address(RVA = "0xAC0950", Offset = "0xABFD50", VA = "0x180AC0950", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
