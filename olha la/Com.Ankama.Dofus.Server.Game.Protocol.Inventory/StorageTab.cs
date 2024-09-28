using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003CD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StorageTab : IMessage<StorageTab>, IMessage, IEquatable<StorageTab>, IDeepCloneable<StorageTab>, IBufferMessage
{
	[Token(Token = "0x4000D0F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StorageTab> _parser;

	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D11")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x4000D12")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x4000D13")]
	public const int TabNumberFieldNumber = 2;

	[Token(Token = "0x4000D14")]
	[FieldOffset(Offset = "0x20")]
	private int tabNumber_;

	[Token(Token = "0x4000D15")]
	public const int PictoFieldNumber = 3;

	[Token(Token = "0x4000D16")]
	[FieldOffset(Offset = "0x24")]
	private int picto_;

	[Token(Token = "0x4000D17")]
	public const int OpenRightFieldNumber = 4;

	[Token(Token = "0x4000D18")]
	[FieldOffset(Offset = "0x28")]
	private int openRight_;

	[Token(Token = "0x4000D19")]
	public const int DropRightFieldNumber = 5;

	[Token(Token = "0x4000D1A")]
	[FieldOffset(Offset = "0x2C")]
	private int dropRight_;

	[Token(Token = "0x4000D1B")]
	public const int TakeRightFieldNumber = 6;

	[Token(Token = "0x4000D1C")]
	[FieldOffset(Offset = "0x30")]
	private int takeRight_;

	[Token(Token = "0x4000D1D")]
	public const int DropTypeLimitFieldNumber = 7;

	[Token(Token = "0x4000D1E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_dropTypeLimit_codec;

	[Token(Token = "0x4000D1F")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<int> dropTypeLimit_;

	[Token(Token = "0x1700087A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StorageTab> Parser
	{
		[Token(Token = "0x60027B2")]
		[Address(RVA = "0x9AEF30", Offset = "0x9AE330", VA = "0x1809AEF30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700087B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60027B3")]
		[Address(RVA = "0x9AEE80", Offset = "0x9AE280", VA = "0x1809AEE80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700087C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60027B4")]
		[Address(RVA = "0x9AF300", Offset = "0x9AE700", VA = "0x1809AF300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700087D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027B9")]
		[Address(RVA = "0x9AF3E0", Offset = "0x9AE7E0", VA = "0x1809AF3E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700087E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TabNumber
	{
		[Token(Token = "0x60027BA")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60027BB")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700087F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Picto
	{
		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000880")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OpenRight
	{
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000881")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DropRight
	{
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17000882")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TakeRight
	{
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17000883")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DropTypeLimit
	{
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027B5")]
	[Address(RVA = "0x9AEDE0", Offset = "0x9AE1E0", VA = "0x1809AEDE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageTab()
	{
	}

	[Token(Token = "0x60027B6")]
	[Address(RVA = "0x9AED20", Offset = "0x9AE120", VA = "0x1809AED20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StorageTab(StorageTab other)
	{
	}

	[Token(Token = "0x60027B7")]
	[Address(RVA = "0x9AE6C0", Offset = "0x9ADAC0", VA = "0x1809AE6C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageTab Clone()
	{
		return null;
	}

	[Token(Token = "0x60027C5")]
	[Address(RVA = "0x9AE880", Offset = "0x9ADC80", VA = "0x1809AE880", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027C6")]
	[Address(RVA = "0x9AE7B0", Offset = "0x9ADBB0", VA = "0x1809AE7B0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StorageTab other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027C7")]
	[Address(RVA = "0x9AE9A0", Offset = "0x9ADDA0", VA = "0x1809AE9A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60027C8")]
	[Address(RVA = "0x9AEB90", Offset = "0x9ADF90", VA = "0x1809AEB90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60027C9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60027CA")]
	[Address(RVA = "0x9AF170", Offset = "0x9AE570", VA = "0x1809AF170", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60027CB")]
	[Address(RVA = "0x9AE500", Offset = "0x9AD900", VA = "0x1809AE500", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60027CC")]
	[Address(RVA = "0x9AEAC0", Offset = "0x9ADEC0", VA = "0x1809AEAC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StorageTab other)
	{
	}

	[Token(Token = "0x60027CD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60027CE")]
	[Address(RVA = "0x9AEF80", Offset = "0x9AE380", VA = "0x1809AEF80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
