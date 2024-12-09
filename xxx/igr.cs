// Ankama.Dofus.Protocol.Game, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// igr
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

[Token(Token = "0x2000570")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class igr : IMessage<igr>, IMessage, IEquatable<igr>, IDeepCloneable<igr>, IBufferMessage
{
	[Token(Token = "0x2000571")]
	public enum igq
	{
		[Token(Token = "0x4001269")]
		None = 0,
		[Token(Token = "0x400126A")]
		InHouseInformation = 10,
		[Token(Token = "0x400126B")]
		Coordinates = 11,
		[Token(Token = "0x400126C")]
		BreachInformation = 12,
		[Token(Token = "0x400126D")]
		AnomalyInformation = 13,
		[Token(Token = "0x400126E")]
		HavenBagInformation = 14
	}

	[Token(Token = "0x4001247")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<igr> dodp;

	[Token(Token = "0x4001248")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet dodq;

	[Token(Token = "0x4001249")]
	public const int dodr = 1;

	[Token(Token = "0x400124A")]
	[FieldOffset(Offset = "0x18")]
	private int dods;

	[Token(Token = "0x400124B")]
	public const int dodt = 2;

	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x20")]
	private long dodu;

	[Token(Token = "0x400124D")]
	public const int dodv = 3;

	[Token(Token = "0x400124E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<jmh> dodw;

	[Token(Token = "0x400124F")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<jmh> dodx;

	[Token(Token = "0x4001250")]
	public const int dody = 4;

	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<jfp> dodz;

	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<jfp> doea;

	[Token(Token = "0x4001253")]
	public const int doeb = 5;

	[Token(Token = "0x4001254")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<jic> doec;

	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<jic> doed;

	[Token(Token = "0x4001256")]
	public const int doee = 6;

	[Token(Token = "0x4001257")]
	[FieldOffset(Offset = "0x20")]
	private static readonly FieldCodec<jid> doef;

	[Token(Token = "0x4001258")]
	[FieldOffset(Offset = "0x40")]
	private readonly RepeatedField<jid> doeg;

	[Token(Token = "0x4001259")]
	public const int doeh = 7;

	[Token(Token = "0x400125A")]
	[FieldOffset(Offset = "0x28")]
	private static readonly FieldCodec<ihc> doei;

	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x48")]
	private readonly RepeatedField<ihc> doej;

	[Token(Token = "0x400125C")]
	public const int doek = 8;

	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0x30")]
	private static readonly FieldCodec<jiy> doel;

	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x50")]
	private readonly RepeatedField<jiy> doem;

	[Token(Token = "0x400125F")]
	public const int doen = 9;

	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x58")]
	private bool doeo;

	[Token(Token = "0x4001261")]
	public const int doep = 10;

	[Token(Token = "0x4001262")]
	public const int doeq = 11;

	[Token(Token = "0x4001263")]
	public const int doer = 12;

	[Token(Token = "0x4001264")]
	public const int does = 13;

	[Token(Token = "0x4001265")]
	public const int doet = 14;

	[Token(Token = "0x4001266")]
	[FieldOffset(Offset = "0x60")]
	private object doeu;

	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0x68")]
	private igq doev;

	[Token(Token = "0x17000C16")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<igr> ekqj
	{
		[Token(Token = "0x6003929")]
		[Address(RVA = "0x770570", Offset = "0x76ED70", VA = "0x180770570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C17")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor ekqk
	{
		[Token(Token = "0x600392A")]
		[Address(RVA = "0x7705C0", Offset = "0x76EDC0", VA = "0x1807705C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C18")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor ekql
	{
		[Token(Token = "0x600392B")]
		[Address(RVA = "0x770640", Offset = "0x76EE40", VA = "0x180770640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C19")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ekqm
	{
		[Token(Token = "0x600392F")]
		[Address(RVA = "0x631300", Offset = "0x62FB00", VA = "0x180631300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003930")]
		[Address(RVA = "0x631380", Offset = "0x62FB80", VA = "0x180631380")]
		set
		{
		}
	}

	[Token(Token = "0x17000C1A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ekqn
	{
		[Token(Token = "0x6003931")]
		[Address(RVA = "0x56EF60", Offset = "0x56D760", VA = "0x18056EF60")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003932")]
		[Address(RVA = "0x6C6D90", Offset = "0x6C5590", VA = "0x1806C6D90")]
		set
		{
		}
	}

	[Token(Token = "0x17000C1B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<jmh> ekqo
	{
		[Token(Token = "0x6003933")]
		[Address(RVA = "0x6C6DA0", Offset = "0x6C55A0", VA = "0x1806C6DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C1C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<jfp> ekqp
	{
		[Token(Token = "0x6003934")]
		[Address(RVA = "0x60E9A0", Offset = "0x60D1A0", VA = "0x18060E9A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C1D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<jic> ekqq
	{
		[Token(Token = "0x6003935")]
		[Address(RVA = "0x61A5B0", Offset = "0x618DB0", VA = "0x18061A5B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C1E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<jid> ekqr
	{
		[Token(Token = "0x6003936")]
		[Address(RVA = "0x572E60", Offset = "0x571660", VA = "0x180572E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C1F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ihc> ekqs
	{
		[Token(Token = "0x6003937")]
		[Address(RVA = "0x60E930", Offset = "0x60D130", VA = "0x18060E930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<jiy> ekqt
	{
		[Token(Token = "0x6003938")]
		[Address(RVA = "0x61A5C0", Offset = "0x618DC0", VA = "0x18061A5C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C21")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool ekqu
	{
		[Token(Token = "0x6003939")]
		[Address(RVA = "0x611C50", Offset = "0x610450", VA = "0x180611C50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600393A")]
		[Address(RVA = "0x611D30", Offset = "0x610530", VA = "0x180611D30")]
		set
		{
		}
	}

	[Token(Token = "0x17000C22")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public igv ekqv
	{
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x7706F0", Offset = "0x76EEF0", VA = "0x1807706F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600393C")]
		[Address(RVA = "0x770750", Offset = "0x76EF50", VA = "0x180770750")]
		set
		{
		}
	}

	[Token(Token = "0x17000C23")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public jmr ekqw
	{
		[Token(Token = "0x600393D")]
		[Address(RVA = "0x770790", Offset = "0x76EF90", VA = "0x180770790")]
		get
		{
			return null;
		}
		[Token(Token = "0x600393E")]
		[Address(RVA = "0x7707F0", Offset = "0x76EFF0", VA = "0x1807707F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C24")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public igx ekqx
	{
		[Token(Token = "0x600393F")]
		[Address(RVA = "0x770830", Offset = "0x76F030", VA = "0x180770830")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003940")]
		[Address(RVA = "0x770890", Offset = "0x76F090", VA = "0x180770890")]
		set
		{
		}
	}

	[Token(Token = "0x17000C25")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public igy ekqy
	{
		[Token(Token = "0x6003941")]
		[Address(RVA = "0x7708D0", Offset = "0x76F0D0", VA = "0x1807708D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003942")]
		[Address(RVA = "0x770930", Offset = "0x76F130", VA = "0x180770930")]
		set
		{
		}
	}

	[Token(Token = "0x17000C26")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public igz ekqz
	{
		[Token(Token = "0x6003943")]
		[Address(RVA = "0x770970", Offset = "0x76F170", VA = "0x180770970")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003944")]
		[Address(RVA = "0x7709D0", Offset = "0x76F1D0", VA = "0x1807709D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C27")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public igq ekra
	{
		[Token(Token = "0x6003945")]
		[Address(RVA = "0x615950", Offset = "0x614150", VA = "0x180615950")]
		get
		{
			return default(igq);
		}
	}

	[Token(Token = "0x600392C")]
	[Address(RVA = "0x770390", Offset = "0x76EB90", VA = "0x180770390")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public igr()
	{
	}

	[Token(Token = "0x600392D")]
	[Address(RVA = "0x76FF30", Offset = "0x76E730", VA = "0x18076FF30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public igr(igr a)
	{
	}

	[Token(Token = "0x600392E")]
	[Address(RVA = "0x76EE20", Offset = "0x76D620", VA = "0x18076EE20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public igr Clone()
	{
		return null;
	}

	[Token(Token = "0x6003946")]
	[Address(RVA = "0x770A10", Offset = "0x76F210", VA = "0x180770A10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void bugp()
	{
	}

	[Token(Token = "0x6003947")]
	[Address(RVA = "0x76F130", Offset = "0x76D930", VA = "0x18076F130", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003948")]
	[Address(RVA = "0x76EE80", Offset = "0x76D680", VA = "0x18076EE80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(igr other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003949")]
	[Address(RVA = "0x76F190", Offset = "0x76D990", VA = "0x18076F190", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600394A")]
	[Address(RVA = "0x76F9D0", Offset = "0x76E1D0", VA = "0x18076F9D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600394B")]
	[Address(RVA = "0x6B8A70", Offset = "0x6B7270", VA = "0x1806B8A70", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600394C")]
	[Address(RVA = "0x770A30", Offset = "0x76F230", VA = "0x180770A30", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void bugq(ref WriteContext a)
	{
	}

	[Token(Token = "0x600394D")]
	[Address(RVA = "0x76E9A0", Offset = "0x76D1A0", VA = "0x18076E9A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600394E")]
	[Address(RVA = "0x76F570", Offset = "0x76DD70", VA = "0x18076F570", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(igr other)
	{
	}

	[Token(Token = "0x600394F")]
	[Address(RVA = "0x6B89F0", Offset = "0x6B71F0", VA = "0x1806B89F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003950")]
	[Address(RVA = "0x770E80", Offset = "0x76F680", VA = "0x180770E80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void bugr(ref ParseContext a)
	{
	}
}
