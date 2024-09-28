using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000550")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapComplementaryHavenBagInformation : IMessage<MapComplementaryHavenBagInformation>, IMessage, IEquatable<MapComplementaryHavenBagInformation>, IDeepCloneable<MapComplementaryHavenBagInformation>, IBufferMessage
{
	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapComplementaryHavenBagInformation> _parser;

	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001239")]
	public const int OwnerInformationFieldNumber = 1;

	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character ownerInformation_;

	[Token(Token = "0x400123B")]
	public const int ThemeFieldNumber = 2;

	[Token(Token = "0x400123C")]
	[FieldOffset(Offset = "0x20")]
	private int theme_;

	[Token(Token = "0x400123D")]
	public const int RoomIdFieldNumber = 3;

	[Token(Token = "0x400123E")]
	[FieldOffset(Offset = "0x24")]
	private int roomId_;

	[Token(Token = "0x400123F")]
	public const int MaxRoomIdFieldNumber = 4;

	[Token(Token = "0x4001240")]
	[FieldOffset(Offset = "0x28")]
	private int maxRoomId_;

	[Token(Token = "0x17000BFE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapComplementaryHavenBagInformation> Parser
	{
		[Token(Token = "0x600386F")]
		[Address(RVA = "0xA25530", Offset = "0xA24930", VA = "0x180A25530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BFF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003870")]
		[Address(RVA = "0xA25480", Offset = "0xA24880", VA = "0x180A25480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003871")]
		[Address(RVA = "0xA257A0", Offset = "0xA24BA0", VA = "0x180A257A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C01")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character OwnerInformation
	{
		[Token(Token = "0x6003875")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003876")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C02")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Theme
	{
		[Token(Token = "0x6003877")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003878")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000C03")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RoomId
	{
		[Token(Token = "0x6003879")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600387A")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C04")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxRoomId
	{
		[Token(Token = "0x600387B")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600387C")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6003872")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryHavenBagInformation()
	{
	}

	[Token(Token = "0x6003873")]
	[Address(RVA = "0xA25400", Offset = "0xA24800", VA = "0x180A25400")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryHavenBagInformation(MapComplementaryHavenBagInformation other)
	{
	}

	[Token(Token = "0x6003874")]
	[Address(RVA = "0xA24F00", Offset = "0xA24300", VA = "0x180A24F00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryHavenBagInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600387D")]
	[Address(RVA = "0xA25030", Offset = "0xA24430", VA = "0x180A25030", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600387E")]
	[Address(RVA = "0xA24FB0", Offset = "0xA243B0", VA = "0x180A24FB0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapComplementaryHavenBagInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600387F")]
	[Address(RVA = "0xA250F0", Offset = "0xA244F0", VA = "0x180A250F0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003880")]
	[Address(RVA = "0xA252A0", Offset = "0xA246A0", VA = "0x180A252A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003881")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003882")]
	[Address(RVA = "0xA256E0", Offset = "0xA24AE0", VA = "0x180A256E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003883")]
	[Address(RVA = "0xA24DF0", Offset = "0xA241F0", VA = "0x180A24DF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003884")]
	[Address(RVA = "0xA251B0", Offset = "0xA245B0", VA = "0x180A251B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapComplementaryHavenBagInformation other)
	{
	}

	[Token(Token = "0x6003885")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003886")]
	[Address(RVA = "0xA25580", Offset = "0xA24980", VA = "0x180A25580", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
